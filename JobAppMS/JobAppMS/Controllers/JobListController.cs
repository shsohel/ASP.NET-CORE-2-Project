using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using JobAppMS.Models;
using JobAppMS.ViewModels;
using JobAppMS.Mappings;
using Microsoft.EntityFrameworkCore;
using JobAppMS.Data;
using AutoMapper;

namespace JobAppMS.Controllers
{
    public class JobListController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public JobListController (ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }


        // For Job List

        [HttpGet]
        public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchString, int? pageNumber)
        {
            ViewData["CurrentSort"] = sortOrder;
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            ViewData["CurrentFilter"] = searchString;
            var jobLists = from s in _db.JobLists
                           select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                jobLists = jobLists.Where(s => s.Position.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    jobLists = jobLists.OrderByDescending(s => s.Position);
                    break;
                default:
                    jobLists = jobLists.OrderBy(s => s.Position);
                    break;
            }
            int pageSize = 3;
            return View(await PaginatedList<JobList>.CreateAsync(jobLists.AsNoTracking(), pageNumber ?? 1, pageSize));
        }


        //public async Task<IActionResult> Index()
        //{
        //    return View(await _db.JobLists.ToListAsync());
        //}


        // For Job List
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // For Job List
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(JoblistVM joblistVM)
        {
            if (ModelState.IsValid)
            {
                var joblist = _mapper.Map<JobList>(joblistVM);
                _db.JobLists.Add(joblist);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(joblistVM);
        }

        // For Job List
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var joblistVM = new JoblistVM();
            {
                JobList joblist = await _db.JobLists.SingleOrDefaultAsync(c => c.JobListID == id);
                if (joblist == null)
                {
                    return NotFound();
                }
                joblistVM.JobListID = joblist.JobListID;
                joblistVM.Position = joblist.Position;
                joblistVM.NumberofPost = joblist.NumberofPost;
                joblistVM.SalaryScale = joblist.SalaryScale;
                joblistVM.AgeLimit = joblist.AgeLimit;
                joblistVM.EducationRequirement = joblist.EducationRequirement;
                joblistVM.LastDateofApplication = joblist.LastDateofApplication;
            }
            return View(joblistVM);
        }


        // For Job List
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(JoblistVM joblistVM)
        {
            if (ModelState.IsValid)
            {
                var jobList = await _db.JobLists.FindAsync(joblistVM.JobListID);
                if (jobList == null)
                {
                    return NotFound();
                }
                var jbl = _mapper.Map<JoblistVM, JobList>(joblistVM, jobList);
                _db.Entry(jbl).State = EntityState.Modified;
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(joblistVM);
        }





        // For Job List
        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var joblistVM = new JoblistVM();
            {
                JobList joblist = await _db.JobLists.SingleOrDefaultAsync(c => c.JobListID == id);
                if (joblist == null)
                {
                    return NotFound();
                }
                joblistVM.JobListID = joblist.JobListID;
                joblistVM.Position = joblist.Position;
                joblistVM.NumberofPost = joblist.NumberofPost;
                joblistVM.SalaryScale = joblist.SalaryScale;
                joblistVM.AgeLimit = joblist.AgeLimit;
                joblistVM.EducationRequirement = joblist.EducationRequirement;
                joblistVM.LastDateofApplication = joblist.LastDateofApplication;
            }
            return View(joblistVM);
        }

        // For Job List
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirm(JoblistVM joblistVM)
        {
            if (ModelState.IsValid)
            {
                var jobList = await _db.JobLists.FindAsync(joblistVM.JobListID);
                if (jobList == null)
                {
                    return NotFound();
                }
                var jbl = _mapper.Map<JoblistVM, JobList>(joblistVM, jobList);
                _db.Entry(jbl).State = EntityState.Deleted;
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(joblistVM);
        }


        // For Job List
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var joblistVM = new JoblistVM();
            {
                JobList joblist = await _db.JobLists.SingleOrDefaultAsync(c => c.JobListID == id);
                if (joblist == null)
                {
                    return NotFound();
                }
                joblistVM.JobListID = joblist.JobListID;
                joblistVM.Position = joblist.Position;
                joblistVM.NumberofPost = joblist.NumberofPost;
                joblistVM.SalaryScale = joblist.SalaryScale;
                joblistVM.AgeLimit = joblist.AgeLimit;
                joblistVM.EducationRequirement = joblist.EducationRequirement;
                joblistVM.LastDateofApplication = joblist.LastDateofApplication;
            }
            return View(joblistVM);
        }

    }
   
}