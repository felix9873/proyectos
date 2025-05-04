using ProyectoModulo2.Models;
using ProyectoModulo2.Models.Abstact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoModulo2.Repository 
{
    public interface IClientRepository : IRepository<Client>
    {
        Client GetByDni(string dni);
        Client GetByEmail(string email);
        List<Order> GetClientOrder(int customerId)
    }

}
