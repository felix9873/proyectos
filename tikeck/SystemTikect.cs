using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tikeck.Models;
using tikeck.Models.Enum;

namespace tikeck
{
    public class SystemTikect
    {
        private List<Ticket> _ticketList = new List<Ticket>();
        private List<Developer> _developerList = new List<Developer>();

        public void addTicket(Ticket ticket)
        {
            _ticketList.Add(ticket);
        }

        public List<Ticket> GetTickets()
        {
            return _ticketList.OrderByDescending(t => t.CreateDate).ToList();
        }
         
        public Ticket GetTicketById(int id)
        {
            return _ticketList.FirstOrDefault(t => t.Id == id);
        }

        public List<Ticket> GetTicketByStatus(StatusTicket status)
        {
            return _ticketList.Where(t => t.Status == status).ToList();
        }

        public List<Ticket> GetTicketByPriority(Priority priority)
        {
            return _ticketList.Where(t => t.Priority == priority).ToList();
        }

        public void UpdatedStatus(int idTicket, StatusTicket status)
        {
            var ticket = GetTicketById(idTicket);

            if (ticket != null) 
            { 
                ticket.UpdateStatus(status);
            }
            else
            {

            }
        }

        public void AssignTicket(int id, Developer developer)
        {
            var ticket = GetTicketById(id);

            if (ticket != null) 
            { 
                ticket.AssignTo(developer);

                if(!developer.AssingTickect.Contains(ticket))
                {
                    developer.AssingTickect.Add(ticket);
                }
            }
        }

        public void AddCommentToTicket(int idTicket,string author, string text)
        {
            var ticket = GetTicketById(idTicket);

            if (ticket != null) 
            {
                var comment = new Comment(author, text);

                if (comment != null) 
                { 
                    ticket.AddSComment(comment);
                }
            }
        }

        public void AddDeveloper(Developer developer)
        {
            _developerList.Add(developer);
        }
    }
}

    

