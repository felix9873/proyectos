using ProyectoModulo2.Models;
using ProyectoModulo2.Models.Abstact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoModulo2.Repository
{
    public interface IBookRepository : IRepository<Book>
    {
        Book GetByTitle(string title);
        List<Order> GetBookOrder(int bookId);

    }
}
