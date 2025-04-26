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

        public void AddTicket(Ticket ticket)
        {
            _ticketList.Add(ticket);
        }

        public List<Ticket> GetTickets()
        {
            return _ticketList.OrderByDescending(t => t.CreateDate).ToList();
        }

        public Ticket GetTicketById(int ticketId)
        {
            return _ticketList.FirstOrDefault(t => t.Id == ticketId);
        }

        public void UpdatedStatus(int ticketId, StatusTicket status)
        {
            var ticket = GetTicketById(ticketId);

            if (ticket != null)
            {
                ticket.UpdatedStatus(status);
            }
            else
            {
                throw new KeyNotFoundException("");
            }
        }

        public void AssigTicket(int ticketId, Developer developer)
        {
            var ticket = GetTicketById(ticketId);

            if (ticket != null)
            {
                ticket.AssignTo(developer);
                if (!developer.AssingTickect.Contains(ticket))
                {
                    developer.AssingTickect.Add(ticket);
                }
            }
            else
            {
                throw new KeyNotFoundException();
            }
        }

        public void AddCommentToTicket(int ticketId, string author, string text)
        {
            var ticket = GetTicketById(ticketId);


            if (ticket != null) 
            { 
                var comment = new Comment(author,text);
                ticket.AddComment(comment);
            }
            else
            {
                throw new KeyNotFoundException();
            }
        }

        public void AddDeveloper(Developer developer)
        {
            _developerList.Add(developer);
        }

        public List<Developer> GetDeveloperList()
        {
            return _developerList;
        }

        public List<Ticket> GetTikectByStatus(StatusTicket statusTicket)
        {
            return _ticketList.Where(t => t.Status == statusTicket).ToList();
        }

        public List<Ticket> GetTicketByPriority(Priority priority)
        {
            return _ticketList.Where(t => t.Priority == priority).ToList();
        }

        public List<Ticket> GetTicketByAssign(string assignName)
        {
            return _ticketList.Where(t =>
            t.AssignedTo != null &&
            t.AssignedTo.Name.ToLower().Contains(assignName.ToLower())).ToList();
        }


    }
}

    

