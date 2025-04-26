using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tikeck.Abstract;

namespace tikeck.Models
{
    public enum Role
    {
        FullStack,
        BackEnd,
        CiberSecurity
    }

    public class Developer : Person
    {
        public static int _id = 1;
        public int Id { get; set; }
        public Role Role { get; set; }
        private List<Ticket> _tickets = new List<Ticket>();
        
        public Developer(Role role )
        {
            Id = _id++;
 
        }

        public void AddTicket(Ticket ticket) 
        { 
            _tickets.Add(ticket);
        }

        public List<Ticket> GetTikect()
        {
            return _tickets;
        }

        public Ticket GetTicketById (int id)
        {
            return _tickets.FirstOrDefault(t => t.Id == id);
        }

        public void ShowTickets (List<Ticket> ticket)
        {
            foreach (var item in ticket)
            {
                Console.WriteLine($"id {item.Id} asssigneed To {item.AssignedTo} create date {item.CreateDate} reporteBy {item.ReporteBy} status {item.Status} status {item.LastUpdated}");
            }
        }
    }

}
