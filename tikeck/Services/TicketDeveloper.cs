
using tikeck.Models;

namespace tikeck.Services
{
    public class TicketService : IServiceTickect
    {
        public void AddTticket(Developer developer)
        {
            Console.WriteLine("add ticket");

            Console.Write("add description");

            string description = Console.ReadLine();

            Ticket tickets = new Ticket() 
            {
                Description = description,
                LastUpdated = DateTime.Now,
            };

            developer.AddTicket(tickets);
        }

        

        public void ShowTickect()
        {
            throw new NotImplementedException();
        }

        public void ShowTicketById()
        {
            throw new NotImplementedException();
        }
    }
}
