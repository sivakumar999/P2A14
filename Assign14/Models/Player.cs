using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Assign14.Models
{
    public class Player
    {
        public int PlayerId { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Jersey Number")]
        public int JerseyNumber { get; set; }

        [Display(Name = "Position")]
        public string Position { get; set; }

        [Display(Name = "Team")]
        public string Team { get; set; }
    }
}