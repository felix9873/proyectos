using ProyectoModulo2.Models;
using ProyectoModulo2.Models.Abstact;
using ProyectoModulo2.Repository;


namespace ProyectoModulo2.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;
        private readonly IOrderRepository _orderRepository;

        public ClientService(IClientRepository clientRepository
            , IOrderRepository orderRepository)
        {
            _clientRepository = clientRepository;
            _orderRepository = orderRepository;
        }

        public Client GetOrCreateClient(string name, string phone, string email, string dni)
        {
            var client = _clientRepository.GetByDni(dni);

            if (client == null) 
            {
                client = new Client
                {
                    Name = name,
                    Email = email,
                    Phone = phone,
                    Dni = dni
                };
                _clientRepository.Add(client);
            }
            return client;
        }

        public List<Client> GetClients() => _clientRepository.GetAll();
       
        public Client GetClientByEmail(string email) => _clientRepository.GetByEmail(email);
        
        public Client GetClientById(int id) => _clientRepository.GetById(id);
        
        public List<Order> GetClientOrder(int clientId)  => _orderRepository.GetOrdeByClient(clientId);

        public void Update(Client client)
        {
            _clientRepository.Update(client);
        }
    }
}
