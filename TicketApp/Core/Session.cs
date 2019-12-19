using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketSystemApp.Models;

namespace TicketSystemApp.Core
{
   public static class Session
    {
      
        public static Form MForm { get; set; }

        public static User User { get; set; }
    }
}
