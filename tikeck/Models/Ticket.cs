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

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }

        public List<Comment> GetComments()
        {
            return Comments;
        }

        public void UpdatedStatus(StatusTicket status)
        {
            Status = status;
            LastUpdated = DateTime.Now;
        }
         
        public void AssignTo(Developer developer)
        {
            AssignedTo = developer;
            LastUpdated = DateTime.Now;
        }

        public Comment GetCommentById(int id)
        {
            return Comments.FirstOrDefault(c => c.Id == id);
        }

        public void ShowComment(List<Comment> comments)
        {
            

            foreach (var item in comments)
            {
                Console.WriteLine($"id {item.Id} text  {item.Text} author  {item.Author}  create date {item.CreatedDate} ");
            }
        }
    }
}
