using ProyectoModulo2.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoModulo2.Models.Abstact
{
    public abstract class Order
    {
        public int Id { get; set; }
        public int IdClient { get; set; }
        public int IdBook { get; set; }
        public Payment AssignToPayment { get; set; }
        public DateTime fechOrder {  get; set; }

        public TypeOrder TypeOrder { get; set; }

        public override string ToString()
        {
            return $"order id {Id} ";
        }

    }
}
