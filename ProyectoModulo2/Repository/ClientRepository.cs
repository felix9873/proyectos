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
        private int _nextId = 1;

        public ClientRepository()
        {
            

            var order = new OrderRent
            {
                Id = 1,
                fechOrder = DateTime.Now,
                AssignToPayment = new PlinPayment 
                {
                    TypePayment = TypePayment.Plin
                },
                TypeOrder = TypeOrder.Rent,
                

            };

            List<Order> orders = new List<Order>() 
            {
                order
            };

            _clients.Add(new Client { 
                Name = "max", Age = 29, 
                Dni = "77234432", 
                Email= "max@gmail.com",
                TypePerson = TypePerson.Client,
                Phone = "983244742",
                Direction = "",
                
                
                
            });
            _clients.Add(new Client
            {
                Name = "max",
                Age = 29,
                Dni = "77234432",
                Email = "max@gmail.com",
                TypePerson = TypePerson.Client,
                Phone = "983244742",
                Direction = "",

            });
            _clients.Add(new Client
            {
                Name = "max",
                Age = 29,
                Dni = "77234432",
                Email = "max@gmail.com",
                TypePerson = TypePerson.Client,
                Phone = "983244742",
                Direction = "",

            });
            _clients.Add(new Client
            {
                Name = "max",
                Age = 29,
                Dni = "77234432",
                Email = "max@gmail.com",
                TypePerson = TypePerson.Client,
                Phone = "983244742",
                Direction = "",

            });
            _clients.Add(new Client
            {
                Name = "max",
                Age = 29,
                Dni = "77234432",
                Email = "max@gmail.com",
                TypePerson = TypePerson.Client,
                Phone = "983244742",
                Direction = "",

            });
        }

        public void Add(Client entity)
        {
            entity.Id = _nextId++;  
            _clients.Add(entity);
        }

        public List<Client> GetAll()
        {
            return _clients;
        }

        public List<Client> GetByDni(string dni)
        {
            return _clients.Where(t => t.Dni == dni).ToList();
        }

        public List<Client> GetByEmail(string email)
        {
            return _clients.Where(t => t.Email == email).ToList();
        }

        public Client GetById(int id)
        {
            return _clients.FirstOrDefault(c => c.Id == id);
        }

        public void Delete(Client entity)
        {
            _clients.Remove(entity);
        }

        public void Update(Client entity)
        {
            var index = _clients.FindIndex(c => c.Id == entity.Id);

            if(index != -1) _clients[index] = entity;
        }
    }
}
