using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemApp.Models
{
  public  class User
    {
        public int Id { get; set; }
        public User()
        {
             Tickets = new HashSet<Ticket>();
        }
        [StringLength(50,MinimumLength =3)]
        [Required]
        public string Name { get; set; }
        [StringLength(50,MinimumLength =3)]
        [Required]
        public string Surname { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [StringLength(30,MinimumLength =5)]
        [Required]
        public string Password { get; set; }
        [Required]
        public bool IsActive { get; set; }
        [Required]
        public byte InvalideTry { get; set; }
        public DateTime? BlockedDate { get; set; }
        [Required]
        public DateTime RegisterDate { get; set; }
        [Required]
        public RoleType RoleType { get; set; }

        public ICollection<Ticket> Tickets { get; set; }
    }
}
