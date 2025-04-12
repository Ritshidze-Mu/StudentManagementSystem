using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;


namespace StudentManagementSystem.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

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
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public List<SelectListItem> GenderOptions { get; set; } = new List<SelectListItem>
    {
        new SelectListItem { Value = "Male", Text = "Male" },
        new SelectListItem { Value = "Female", Text = "Female" },
        new SelectListItem { Value = "Other", Text = "Other" }
    };

        [Required(ErrorMessage = "ID Number is required")]
        [StringLength(13, MinimumLength = 13, ErrorMessage = "ID Number must be exactly 13 digits")]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "ID Number must contain only digits")]
        [Display(Name = "ID Number")]
        public string IdNumber { get; set; }

        [Required(ErrorMessage = "Student Number is required")]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "Student Number must be exactly 8 digits")]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Student Number must contain only digits")]
        [Display(Name = "Student Number")]
        public string StudentNumber { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [StringLength(256)]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@dut4life\.ac\.za$",
            ErrorMessage = "Email must be a valid @dut4life.ac.za address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone Number is required")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Phone Number must be exactly 10 digits")]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Phone Number must contain only digits")]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        // Navigation property for Identity User
       

    
    }
}