using ProyectoModulo2.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoModulo2.Models.Interfaz
{
    public interface IPayment
    {
        public void ProcessPayment(TypePayment typePayment);
    }
}
