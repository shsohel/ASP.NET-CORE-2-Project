using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobAppMS.Models
{
    public class JobApplication
    {
        [Key]
        public int JobApplicationID { get; set; }

        [Required(ErrorMessage = "User Name is Required!!")]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "PhoneNumber is Required!!")]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }


        [Required(ErrorMessage = "Select the Job ")]
        [Display(Name = "Job Title")]
        public int JobListID { get; set; }

        public virtual JobList JobList { get; set; }

    }
}
