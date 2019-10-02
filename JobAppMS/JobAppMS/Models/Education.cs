using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobAppMS.Models
{
    public class Education
    {
        [Key]
        public int EduID { get; set; }

        [Required(ErrorMessage = "User Name is Required!!")]
        [Display(Name = "User Name")]
        public string UserName { get; set; }


        [Required(ErrorMessage = "Exam Degree Title is Required!!")]
        [Display(Name = "Input Last Degree")]
        public string ExamDegreeTitle { get; set; }

        [Required(ErrorMessage = "Group Major Subject  is Required!!")]
        [Display(Name = "Major Subject")]
        public string GroupMajorSubject { get; set; }


        [Required(ErrorMessage = "Institute/University  is Required!!")]
        [Display(Name = "Institute/University")]
        public string InstituteUniversity { get; set; }
        public string Result { get; set; }
        public decimal CGPA { get; set; }
        public decimal Scale { get; set; }


        [Required(ErrorMessage = "Year of Passing  is Required!!")]
        [Display(Name = "Passing Year ")]
        public int YearOfPassing { get; set; }
        public int Duration { get; set; }

 
    }
}
