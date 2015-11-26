using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ExperimentWeb1.Models
{
    public class Person
    {
        [Display(Name = "first name")]
        [Required]
        public string Name { set; get; }

        [Display(Name = "Last Name")]
        [Required]
        public string LastName { set; get; }
    }
}