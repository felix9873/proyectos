using ProyectoModulo2.Models.Abstact;
using ProyectoModulo2.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoModulo2.Models
{
    public class Employee : Person
    {
        public TypePerson Type { get; set; }

        public override string ToString()
        {
            return $"employee  {Name} id {Id} Dni {Dni} {}";
        }


    }
}
