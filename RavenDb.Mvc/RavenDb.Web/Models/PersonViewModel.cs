using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RavenDb.Web.Models
{
    public class PersonViewModel
    {
        [Display(Name = "Person ID")]
        public int Id { get; set; }

        [Display(Name = "First Name")]
        [DisplayFormat(NullDisplayText = "N/A")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [DisplayFormat(ConvertEmptyStringToNull = true)]
        public string LastName { get; set; }
    }
}