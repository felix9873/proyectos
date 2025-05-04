using ProyectoModulo2.Models;
using ProyectoModulo2.Models.Abstact;
using ProyectoModulo2.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoModulo2.Services
{
    public interface IOrderService
    {
        
        Order GetOrdeById(int id);
        List<Order> GetOrders();

        Payment AssignPayment(Payment payment);

        List<Order> GetOrderByClientId(int ClientId);
        List<Order> GetOrderByIdBook(int id);

        void Add(Order order);
    }
}
