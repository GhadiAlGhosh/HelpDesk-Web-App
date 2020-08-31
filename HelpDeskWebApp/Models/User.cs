using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpDeskWebApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }

        public ICollection<Ticket> Tickets { get; set; }
    }
}
