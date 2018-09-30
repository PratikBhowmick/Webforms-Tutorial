using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Demo.Models
{
    public class StudentModel
    {        
        public int id { get; set; }

        [DisplayName("Name :")]
        [Required]
        public string name { get; set; }

        [Required]
        [Range(18, 30)]
        [DisplayName("Marks :")]
        public int marks { get; set; }

        [Required(ErrorMessage = "City is required")]
        [StringLength(60, MinimumLength = 4, ErrorMessage = "{0} should be between 4 to 60 Char")]
        [DisplayName("City :")]
        public string city { get; set; }
    }
}