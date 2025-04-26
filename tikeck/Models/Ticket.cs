using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tikeck.Models
{
    public enum StatusTicket
    {
        Active,
        Inactive,
        Pause
    }
    public class Ticket
    {
        public static int _id = 1;
        public int Id { get; set; }
        public string Description { get; set; }
        public StatusTicket Status { get; set; }

        public string ReporteBy { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdated {  get; set; }
        public Developer AssignedTo { get; set; }   

        List<Comment> _comments = new List<Comment>();


        public Ticket()
        {
            Id = _id++;
        }

        public void AddComment(Comment comment)
        {
            _comments.Add(comment);
        }

        public List<Comment> comments()
        {
            return _comments;
        }

        public Comment GetCommentById(int id)
        {
            return _comments.FirstOrDefault(c => c.Id == id);
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
