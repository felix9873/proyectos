using ProyectoModulo2.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoModulo2.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        
        public GenderBook GenderBook { get; set; }

        public override string ToString()
        {
            return $"title {Title} id {Id} author {Author} gender book {GenderBook.ToString()}";
        }

        
    }
}
