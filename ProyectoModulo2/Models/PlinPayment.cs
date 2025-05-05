using ProyectoModulo2.Models.Abstact;
using ProyectoModulo2.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoModulo2.Models
{
    public class PlinPayment : Payment
    {
        public virtual void ProcessPayment(TypePayment typePayment)
        {
            Console.WriteLine($"payment with {typePayment}");
        }
    }
}
