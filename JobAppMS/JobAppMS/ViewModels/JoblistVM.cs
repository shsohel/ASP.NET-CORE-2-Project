using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobAppMS.ViewModels
{
    public class JoblistVM
    {
        [Key]
        public int JobListID { get; set; }

        [Required(ErrorMessage = "Must be inputed  Job Position ")]
        [Display(Name = "Job Post of Position")]
        public string Position { get; set; }

        [Required(ErrorMessage = "Must be inputed  Total Job Post ")]
        [Display(Name = "Number of Post")]
        public int NumberofPost { get; set; }

        [Required(ErrorMessage = "Must be inputed  Salary Ranges ")]
        [Display(Name = "Salary Ranges")]
        public string SalaryScale { get; set; }

        [Required(ErrorMessage = "Must be inputed Age Limitation ")]
        [Display(Name = "Age Limitation ")]
        public string AgeLimit { get; set; }

        [Required(ErrorMessage = "Must be inputed Education Qualification ")]
        [Display(Name = "Education Qualification ")]
        public string EducationRequirement { get; set; }

        [Display(Name = "Application End Date ")]
        [DataType(DataType.Date)]
        public DateTime LastDateofApplication { get; set; }
    }
}
