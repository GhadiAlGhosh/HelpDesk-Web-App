using HelpDeskWebApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading.Tasks;

namespace HelpDeskWebApp.Data
{
    public static class DbInitializer
    {
        public static void Initialize(HelpDeskContext context)
        {
            context.Database.EnsureCreated();

            //Look for any tickets.
            if (context.Tickets.Any())
            {
                return;   // DB has been seeded
            }

            var tickets = new Ticket[]
            {
            new Ticket{Id=1050,TicketDate=DateTime.Parse("2005-09-01"),Category=Category.Desktop,UserId=1},
            new Ticket{Id=4022,TicketDate=DateTime.Parse("2006-09-01"),Category=Category.Laptop,UserId=1},
            new Ticket{Id=4041,TicketDate=DateTime.Parse("2020-09-01"),Category=Category.Server,UserId=5},
            new Ticket{Id=1045,TicketDate=DateTime.Parse("2015-09-01"),Category=Category.Desktop,UserId=5},
            new Ticket{Id=3141,TicketDate=DateTime.Parse("2020-08-01"),Category=Category.Server,UserId=5},
            new Ticket{Id=2021,TicketDate=DateTime.Parse("2005-09-01"),Category=Category.Software,UserId=5},
            new Ticket{Id=2042,TicketDate=DateTime.Parse("2019-09-01"),Category=Category.Desktop,UserId=3}

            };
            foreach (Ticket t in tickets)
            {
                context.Tickets.Add(t);
            }
            context.SaveChanges();

            var users = new User[]
            {
            new User{FirstMidName="Carson",LastName="Alexander",Id=1},
            new User{FirstMidName="Meredith",LastName="Alonso",Id=5},
            new User{FirstMidName="Arturo",LastName="Anand",Id=4},
            new User{FirstMidName="Gytis",LastName="Barzdukas",Id=5},
            new User{FirstMidName="Yan",LastName="Li",Id=7},
            new User{FirstMidName="Peggy",LastName="Justice",Id=9},
            new User{FirstMidName="Laura",LastName="Norman",Id=3},
            new User{FirstMidName="Nino",LastName="Olivetto",Id=2}
            };
            foreach (User u in users)
            {
                context.Users.Add(u);
            }
            context.SaveChanges();

        }

    }
}
