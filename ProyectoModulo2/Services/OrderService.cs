using ProyectoModulo2.Models;
using ProyectoModulo2.Models.Abstact;
using ProyectoModulo2.Models.Enum;
using ProyectoModulo2.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoModulo2.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public void Add(Order order)
        {
            _orderRepository.Add(order);
        }

        public Payment AssignPayment(Payment payment)
        {
           return  _orderRepository.AssignPayment(payment);
        }

        public Order GetOrdeById(int id)
        {
           return _orderRepository.GetById(id);
        }

        public List<Order> GetOrderByClientId(int ClientId)
        {
            return _orderRepository.GetOrdeByClient(ClientId);
        }

        public List<Order> GetOrderByIdBook(int id)
        {
            return _orderRepository.GetOrdeByBook(id );
        }

        public List<Order> GetOrders()
        {
           return _orderRepository.GetAll();
        }
    }
}
