using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using AutoMapper;
using JobAppMS.Models;
using JobAppMS.ViewModels;

namespace JobAppMS.Mappings
{
    public class JobListProfile:Profile
    {
        public JobListProfile()
        {
            CreateMap<JobList, JoblistVM>();
            CreateMap<JoblistVM, JobList>()
            .ForMember(v => v.JobListID, opt => opt.Ignore());


            CreateMap<PersonalDetail, ApplyVM>();
            CreateMap<ApplyVM, PersonalDetail>()
            .ForMember(v => v.PersonalID, opt => opt.Ignore());


            CreateMap<JobApplication, JobRegVM>();
            CreateMap<JobRegVM, JobApplication>()
            .ForMember(v => v.JobApplicationID, opt => opt.Ignore());
        }


    }
}
