using ProyectoModulo2.Models.Abstact;
using ProyectoModulo2.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoModulo2.Repository
{
    public class OrdeRepository : IOrderRepository
    {
        private List<Order> _orders = new List<Order>();

        public List<Order> GetAll()
        {
            return _orders;
        }
        public Order GetById(int id)
        {
            return _orders.FirstOrDefault(o => o.Id == id);
        }

        public void Add(Order entity)
        {
            _orders.Add(entity);
        }

        public void Update(Order entity)
        {
            var index = _orders.FindIndex(o => o.Id == entity.Id);

            if(index != -1) _orders[index] = entity;
        }

        public void Delete(Order entity)
        {
            _orders.Remove(entity);
        }

        public List<Order> GetByTypeOrder(TypeOrder type)
        {
            return _orders.Where(o => o.TypeOrder == type).ToList();
        }

        public List<Payment> GetPayment()
        {
            throw new NotImplementedException();
        }

        
    }
}
