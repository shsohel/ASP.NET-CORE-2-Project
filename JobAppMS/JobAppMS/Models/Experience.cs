using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobAppMS.Models
{
    public class Experience
    {
        [Key]
        public int ExperienceID { get; set; }

        [Required(ErrorMessage = "User Name Title is Required!!")]
        [Display(Name = "User")]
        public string UserName { get; set; }

        [Display(Name = "Company")]
        public string CompanyName { get; set; }

        [Display(Name = "Company Business")]
        public string CompanyBusiness { get; set; }
        public string Designation { get; set; }
        public string Department { get; set; }

        [Display(Name = "Start")]

        [DataType(DataType.Date)]
        public DateTime startDate { get; set; }

        [Display(Name = "End")]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
        public string Skill { get; set; }

    }
}
