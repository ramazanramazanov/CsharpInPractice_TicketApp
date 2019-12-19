using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemApp.Models
{
   public class LoginModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [StringLength(30, MinimumLength = 5)]
        [Required]
        public string Password { get; set; }

        [Compare("Password")]
        [Required]
        public string ConfirPassword { get; set; }
    }
}
