using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tikeck.Models.Enum;

namespace tikeck.Models
{
   
    public class Ticket
    {
        public static int _id = 1;

        public string Title { get; set; }
        public int Id { get; set; }
        public string Description { get; set; }
        public StatusTicket Status { get; set; }

        public Priority Priority { get; set; }

        public string ReporteBy { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdated {  get; set; }
        public Developer AssignedTo { get; set; }

        public List<Comment> Comments { get; set; } = new List<Comment>();


        public Ticket()
        {
            Id = _id++;
        }

        public void AddSComment(Comment comment)
        {
            Comments.Add(comment);
        }

        public void UpdateStatus(StatusTicket  status)
        {
            Status = status;
            CreateDate = DateTime.Now;
        }

        public void AssignTo(Developer developer)
        {
            AssignedTo = developer;
            CreateDate = DateTime.Now;
        }


    }
}
