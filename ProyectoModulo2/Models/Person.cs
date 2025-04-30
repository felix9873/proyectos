using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoModulo2.Models
{
    public abstract class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Dni {  get; set; }
        public string Email { get; set; }

        public int Age { get; set; }

        public string Phone { get; set; }
    }
}
