using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tikeck.Abstract;
using tikeck.Models.Enum;

namespace tikeck.Models
{
    
    public class Developer : Person
    {
        public static int _id = 1;
        public int Id { get; set; }
        public RoleDeveloper Role { get; set; }
        public List<Ticket> AssingTickect { get; set; } = new List<Ticket>();
        
        public Developer(RoleDeveloper role )
        {
            Id = _id++;
 
        }

       
    }

}
