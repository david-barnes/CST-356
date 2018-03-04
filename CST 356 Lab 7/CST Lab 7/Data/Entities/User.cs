﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace CST_356_Lab_2.Data.Entities
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }
        [Required]
        [Display(Name = "Years in School")]
        public int YearsInSchool { get; set; }

    }
}