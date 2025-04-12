using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace StudentManagementSystem.Models
{
    public class RegisterViewModel
    {
        

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@dut4life\.ac\.za$",
            ErrorMessage = "Email must be a valid @dut4life.ac.za address")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 8)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [System.Web.Mvc.Compare("Password", ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, ErrorMessage = "Name cannot exceed 50 characters")]
        [Display(Name = "First Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Surname is required")]
        [StringLength(50, ErrorMessage = "Surname cannot exceed 50 characters")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Date of Birth is required")]
        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; } = DateTime.Now.AddYears(-18);

        [Required]
        public string Gender { get; set; }

        // This should be List<SelectListItem> (from System.Web.Mvc)
        public List<SelectListItem> GenderOptions { get; set; } = new List<SelectListItem>
    {
        new SelectListItem { Value = "Male", Text = "Male" },
        new SelectListItem { Value = "Female", Text = "Female" },
        new SelectListItem { Value = "Other", Text = "Other" }
    };


        // This should be List<SelectListItem> (from System.Web.Mvc)

        [Required(ErrorMessage = "ID Number is required")]
        [StringLength(13, MinimumLength = 13, ErrorMessage = "ID must be 13 digits")]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Only numbers allowed")]
        [Display(Name = "ID Number")]
        public string IdNumber { get; set; }

        [Required(ErrorMessage = "Student Number is required")]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "Student number must be 8 digits")]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Only numbers allowed")]
        [Display(Name = "Student Number")]
        public string StudentNumber { get; set; }

        [Required(ErrorMessage = "Phone Number is required")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Phone must be 10 digits")]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Only numbers allowed")]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
    }
}