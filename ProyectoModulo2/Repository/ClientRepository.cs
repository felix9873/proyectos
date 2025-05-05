using ProyectoModulo2.Models;
using ProyectoModulo2.Models.Abstact;
using ProyectoModulo2.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoModulo2.Repository
{
   public class ClientRepository : IClientRepository
   {
        private List<Client> _clients = new List<Client>();
        private List<Order> _orders = new List<Order>();
        private int _nextId = 1;

        public List<Client> GetAll()
        {
            return _clients;
        }
        public Client GetById(int id)
        {
            return _clients.FirstOrDefault(c => c.Id == id);
        }

        public void Add(Client entity)
        {
            entity.Id = _nextId++;  
            _clients.Add(entity);
        }

        public void Update(Client entity)
        {
            var index = _clients.FindIndex(c => c.Id == entity.Id);

            if (index != -1) _clients[index] = entity;
        }

        public void Delete(Client entity)
        {
            _clients.Remove(entity);
        }


        public Client GetByDni(string dni)
        {
            return _clients.FirstOrDefault(c => c.Dni == dni);
        }

        public Client GetByEmail(string email)
        {
            return _clients.FirstOrDefault(c => c.Email == email);
        }

        public List<Order> GetClientOrder(int clientId)
        {
            return _orders.Where(o => o.IdClient == clientId).ToList();
        }
    }
}
