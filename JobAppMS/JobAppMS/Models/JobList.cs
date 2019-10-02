using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobAppMS.Models
{
    public class JobList
    {
        [Key]
        public int JobListID { get; set; }
        public string Position { get; set; }
        public int NumberofPost { get; set; }
        public string SalaryScale { get; set; }
        public string AgeLimit { get; set; }
        public string EducationRequirement { get; set; }
        [DataType(DataType.Date)]
        public DateTime LastDateofApplication { get; set; }

        public virtual ICollection<JobApplication> JobApplications { get; set; }

    }
}
