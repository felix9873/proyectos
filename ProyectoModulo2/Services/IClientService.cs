using ProyectoModulo2.Models;
using ProyectoModulo2.Models.Abstact;


namespace ProyectoModulo2.Services
{
    public interface IClientService
    {
        Client  GetOrCreateClient(string name, string phone, string email, string dni);
        Client GetClientById(int id);
        List<Client> GetClients();
        Client GetClientByEmail(string email);
        List<Order> GetClientOrder(int clientId);

        void Update(Client client);
    }
}
