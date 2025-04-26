using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tikeck.Models
{
    public class Comment
    {
        public static int _Id = 1;
        public int Id { get; set; }
        public string Author { get; set; }
        public string Text { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public Comment(string author, string text)
        {
            Id = _Id++;
            Author = author;
            Text = text;
            
          
        }
    }
}
