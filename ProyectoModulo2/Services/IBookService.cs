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
    public interface IBookService
    {
        Book GetOrCreateBook(string title, string author, GenderBook genderBook);
        Book GetBookById(int id);
        List<Book> GetBooks();
        Book GetBookByTitle(string title);
        List<Order> GetBookOrder(int bookId);
    }
}
