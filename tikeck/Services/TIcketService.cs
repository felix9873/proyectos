using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using tikeck.Models;

namespace tikeck.Services
{
    public class TIcketService : ITicketService
    {
        public void AddTicket(SystemTikect system)
        {
            List<Comment> comments = new List<Comment>();

            Console.WriteLine("ingresa el comment");

            string comment = Console.ReadLine();

            Console.WriteLine("ingresa el author");

            string author = Console.ReadLine();

            var commentObj = new Comment(author, comment);
            

            comments.Add(commentObj);

            var ticket = new Ticket
            {
                Comments = comments,
                CreateDate = DateTime.Now,
                LastUpdated = DateTime.Now,
            };

            system.AddTicket(ticket);

            Console.WriteLine($"ticket agregado con el id {ticket.Id}");
        }

        public void ShowTicket(SystemTikect system)
        {
            var tickets = system.GetTickets();
            
            

            Console.WriteLine("Lista de ticket");

            foreach (var ticket in tickets)
            {
                Console.WriteLine($"Id {ticket.Id} {ticket.CreateDate} {ticket.ShowComment}");
            }
        }

        public void ShowTicketById(SystemTikect system)
        {
            throw new NotImplementedException();
        }
    }
}
