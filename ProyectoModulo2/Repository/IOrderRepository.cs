using ProyectoModulo2.Models.Abstact;
using ProyectoModulo2.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoModulo2.Repository
{
    public interface IOrderRepository : IRepository<Order>
    {
        List<Order> GetByTypeOrder(TypeOrder type);
        List<Payment> GetPayment();
    }
}
