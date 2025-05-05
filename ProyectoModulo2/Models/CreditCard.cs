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
    public class CreditCard : Payment
    {
        public virtual void ProcessPayment(TypePayment typePayment)
        {
            Console.WriteLine($"payment with {typePayment}");
        }
    }
}
