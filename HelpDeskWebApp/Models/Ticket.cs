using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpDeskWebApp.Models
{
   public enum Category
    {
        Laptop,
        Desktop,
        Server,
        Software
    }

    public class Ticket
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; }
        public Category? Category { get; set; }
        public DateTime TicketDate { get; set; }

        public User User { get; set; }
    }
    
}
