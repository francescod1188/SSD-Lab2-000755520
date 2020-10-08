using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1_000755520.Models
{
    public class Team
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Team Name")]
        [Required(ErrorMessage = "The Team Name is required")]
        public string TeamName { get; set; }

        [Display(Name = "Email address")]
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Display(Name = "Date Established")]
        public DateTime EstablishedDate { get; set; }
    }
}
