using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tikeck.Abstract
{
    public enum Gender
    {
        Male,
        Female,
        
    }
    public class Person
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public string Dni { get; set; }
        public string  Direction { get; set; }
        public int Age { get; set; }

        
    }
}
