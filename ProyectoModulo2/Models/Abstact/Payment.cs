using ProyectoModulo2.Models.Enum;
using ProyectoModulo2.Models.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoModulo2.Models.Abstact
{
    public abstract class Payment : IPayment
    {
        public TypePayment TypePayment { get; set; }
        public virtual void ProcessPayment(TypePayment typePayment)
        {
            Console.WriteLine($"payment with {typePayment}"); 
        }

        public override string ToString()
        {
            return $"{TypePayment.ToString()}";
        }
    }
}
