using ProyectoModulo2.Models.Abstact;
using ProyectoModulo2.Models.Enum;
using ProyectoModulo2.Models.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoModulo2.Models
{
    public class Client : Person
    {
        public List<Order> Orders {  get; set; } = new List<Order>();
        public TypePerson TypePerson { get; set; }

        public override string ToString()
        {
            return $"Client  {Name}  dni {Dni}  direction {Direction}  Phone {Phone} ";
        }
    }
}
