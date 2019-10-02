using JobAppMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using JobAppMS.Data;
using System.ComponentModel.DataAnnotations;

namespace JobAppMS.ViewModels
{
    public class ApplyVM
    {

        [Key]
        public int PersonalID { get; set; }

        [Required(ErrorMessage = "User Name is Required!!")]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Yours Name is Required!!")]
        [Display(Name = "Full Name")]
        [StringLength(30, MinimumLength = 6, ErrorMessage = "Your Name must be between 6 to 10 character")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Father Name is Required!!")]
        [Display(Name = "Father Name")]
        [StringLength(30, MinimumLength = 6, ErrorMessage = "Your Father Name must be between 6 to 10 character")]
        public string FathersName { get; set; }

        [Required(ErrorMessage = "Yours Name is Required!!")]
        [Display(Name = "Full Name")]
        public string MothersName { get; set; }

        [Display(Name = "Birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public string Religion { get; set; }

        [Required]
        public string Nationality { get; set; }

        [Required(ErrorMessage = "Marital Status is Required!!")]
        [Display(Name = "Marital Status")]
        public string MaritalStatus { get; set; }


        [Required(ErrorMessage = "Upload Your Photo is Required!!")]
        [Display(Name = "Your Photo")]
        public string UserPicture { get; set; }
    }
}
