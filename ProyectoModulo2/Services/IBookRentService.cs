using ProyectoModulo2.Models;
using ProyectoModulo2.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoModulo2.Services
{
    public interface IBookRentService 
    {
        List<Book> GetBooksRent();

        void Add(Book book);
    }
}
