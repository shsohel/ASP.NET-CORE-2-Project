using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

using JobAppMS.Models;

namespace JobAppMS.ViewModels
{
    public class JobRegVM
    {
        public int JobApplicationID { get; set; }

        [Required(ErrorMessage = "Must be Login First For USER NAME ")]
        [Display(Name = "User Name")]
        public string UserName { get; set; }


        [Required(ErrorMessage = "Must be Login First For Phone Number ")]
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }


        [Required(ErrorMessage = " Must be Selectet Your Desired Job ")]
        [Display(Name = "Job Title")]
        public int JobListID { get; set; }

        public virtual JobList JobList { get; set; }
    }
}
