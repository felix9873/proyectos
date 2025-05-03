using ProyectoModulo2.Models.Abstact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoModulo2.Models
{
    public class CashPayment : Payment
    {
        public override void ProcessPayment(float amount, string message)
        {
            Console.WriteLine($"amount {amount} with {message}");
        }
    }
}
