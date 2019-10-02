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
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.FileProviders;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Authorization;

namespace JobAppMS.Controllers
{
    public class ApplyJobController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        private readonly IFileProvider fileProvider;
        private readonly IHostingEnvironment hostingEnvironment;


        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ILogger _logger;

        public ApplyJobController(ApplicationDbContext db, IMapper mapper, IFileProvider fileprovider, IHostingEnvironment env, UserManager<ApplicationUser> userManager,
                    SignInManager<ApplicationUser> signInManager,
                    ILogger<AccountController> logger)
        {
            _db = db;
            _mapper = mapper;
            fileProvider = fileprovider;
            hostingEnvironment = env;

            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
        }




        [Authorize(Roles ="Admin")]
        //public IList<PersonalDetail> Getperson { get; set; }
        public async Task <IActionResult> Getperson ()
        {
             return View( await _db.PersonalDetails.ToListAsync());
        }



        [Route("Input/Resume")]
        //For Person
        [HttpGet]
        public IActionResult Crepersoon()
        {
            return View();
        }


        //For Person
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Crepersoon(ApplyVM applyVM, IFormFile file)
        {


            if (ModelState.IsValid)
            {
                var person = _mapper.Map<PersonalDetail>(applyVM);
                _db.PersonalDetails.Add(person);

                await _db.SaveChangesAsync();

                // Code to upload image if not null
                if (file != null || file.Length != 0)
                {
                    // Create a File Info 
                    FileInfo fi = new FileInfo(file.FileName);

                    // This code creates a unique file name to prevent duplications 
                    // stored at the file location
                    var newFilename = person.PersonalID + "_" + String.Format("{0:d}",
                                      (DateTime.Now.Ticks / 10) % 100000000) + fi.Extension;
                    var webPath = hostingEnvironment.WebRootPath;
                    var path = Path.Combine("", webPath + @"\ImageFiles\" + newFilename);

                    // IMPORTANT: The pathToSave variable will be save on the column in the database
                    var pathToSave = @"/ImageFiles/" + newFilename;

                    // This stream the physical file to the allocate wwwroot/ImageFiles folder
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }

                    // This save the path to the record
                    person.UserPicture = pathToSave;
                    _db.Update(person);
                    await _db.SaveChangesAsync();
                }
                return RedirectToAction(nameof(Educreate));
            }
            return View(applyVM);

        }



       //For Person
        public async Task<IActionResult> Detailperson(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personalDetail = await _db.PersonalDetails
                .FirstOrDefaultAsync(m => m.PersonalID == id);
            if (personalDetail == null)
            {
                return NotFound();
            }

            return View(personalDetail);
        }


        //For Person
        [HttpGet]
        public async Task<IActionResult> Deleteperson(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personalDetail = await _db.PersonalDetails
                .FirstOrDefaultAsync(m => m.PersonalID == id);
            if (personalDetail == null)
            {
                return NotFound();
            }

            return View(personalDetail);
        }

        //For Person
        [HttpPost, ActionName("Deleteperson")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var personalDetail = await _db.PersonalDetails.FindAsync(id);
            _db.PersonalDetails.Remove(personalDetail);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Getperson));
        }



        // For Education Info
        [HttpGet] 
        public async Task<IActionResult> Geteduinfo()
        {
            return View(await _db.Educations.ToListAsync());
        }

        // For Education Info
        [HttpGet]
        public IActionResult Educreate()
        {           

            return View();
        }

        // For Education Info

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Educreate(Education education)
        {
   
            if (ModelState.IsValid)
            {
                _db.Add(education);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Excreate));
            }
            
            return View(education);
        }

        // For Education Info
        [HttpGet]
        public async Task<IActionResult> Detailedu(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var educationDetail = await _db.Educations
                .FirstOrDefaultAsync(m => m.EduID == id);
            if (educationDetail == null)
            {
                return NotFound();
            }

            return View(educationDetail);
        }

        // For Education Info
        [HttpGet]
        public async Task<IActionResult> Deleteedu(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eduDetail = await _db.Educations
                .FirstOrDefaultAsync(m => m.EduID == id);
            if (eduDetail == null)
            {
                return NotFound();
            }

            return View(eduDetail);
        }



        // For Education Info
        [HttpPost, ActionName("Deleteedu")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmededu(int id)
        {
            var eduDetail = await _db.Educations.FindAsync(id);
            _db.Educations.Remove(eduDetail);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Getperson));
        }





        // For Experience Info

        [HttpGet] //GetExprerience 
        public async Task<IActionResult> Getexinfo()
        {
            return View(await _db.Experience.ToListAsync());
        }




        // For Experience Info

        [HttpGet]
        public IActionResult Excreate()
        {
           
            return View();
        }

        // For Experience Info
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Excreate( Experience experience)
        {
            if (ModelState.IsValid)
            {
                _db.Add(experience);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Traineecreate));
            }
            return View(experience);
        }

        // For Experience Info
        [HttpGet]
        public async Task<IActionResult> Detailex(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exDetail = await _db.Experience
                .FirstOrDefaultAsync(m => m.ExperienceID == id);
            if (exDetail == null)
            {
                return NotFound();
            }

            return View(exDetail);
        }

        // For Experience Info
        [HttpGet]
        public async Task<IActionResult> Deleteex(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exDetail = await _db.Experience
                .FirstOrDefaultAsync(m => m.ExperienceID == id);
            if (exDetail == null)
            {
                return NotFound();
            }

            return View(exDetail);
        }

        // For Experience Info
        [HttpPost, ActionName("Deleteex")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmedex(int id)
        {
            var exDetail = await _db.Experience.FindAsync(id);
            _db.Experience.Remove(exDetail);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Getperson));
        }




        // For Training Info

        [HttpGet] 
        public async Task<IActionResult> Gettraininfo()
        {
            return View(await _db.Training.ToListAsync());
        }




        // For Training Info
        [HttpGet]
        public IActionResult Traineecreate()
        {
            return View();
        }

        // For Training Info

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Traineecreate( Training training)
        {
            if (ModelState.IsValid)
            {
                _db.Add(training);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }
            return View(training);
        }


        // For Training Info
        [HttpGet]
        public async Task<IActionResult> Detailtrain(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exDetail = await _db.Training
                .FirstOrDefaultAsync(m => m.TrainingID == id);
            if (exDetail == null)
            {
                return NotFound();
            }

            return View(exDetail);
        }

        // For Training Info
        [HttpGet]
        public async Task<IActionResult> Deletetrain(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trainDetail = await _db.Training
                .FirstOrDefaultAsync(m => m.TrainingID == id);
            if (trainDetail == null)
            {
                return NotFound();
            }

            return View(trainDetail);
        }

        // For Training Info
        [HttpPost, ActionName("Deletetrain")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmedtrain(int id)
        {
            var exDetail = await _db.Experience.FindAsync(id);
            _db.Experience.Remove(exDetail);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Getperson));
        }






        [Authorize(Roles ="Admin")]
        // For Application Info
        [HttpGet]
        public async Task<IActionResult> GetApplyList()
        {
            var applicationDbContext = _db.JobApplication.Include(j => j.JobList);

            return View( await _db.JobApplication.ToListAsync());
        }


        // For Application Info
        [HttpGet]
        public IActionResult Jobapply()
        {

            ViewData["Position"] = new SelectList(_db.JobLists, "JobListID", "Position");

            return View();
        }

        // For Application Info
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Jobapply(JobRegVM jobRegVM)
        {
            if (ModelState.IsValid)
            {
                var joblistvm = _mapper.Map<JobApplication>(jobRegVM);
                _db.JobApplication.Add(joblistvm);
                await _db.SaveChangesAsync();
                return RedirectToAction( "Index", "JobList");
            }
            ViewData["Position"] = new SelectList(_db.JobLists, "JobListID", "Position", jobRegVM.JobListID);

            return View(jobRegVM);
        }

    }
}