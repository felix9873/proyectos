using ProyectoModulo2.Models;
using ProyectoModulo2.Models.Abstact;
using ProyectoModulo2.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoModulo2.Services
{
    public class BookRentSevice : IBookRentService
    {
        
        private readonly IBookRentrRepository _bookRentrRepository;
        public BookRentSevice(IBookRentrRepository bookRentrRepository)
        {
            _bookRentrRepository = bookRentrRepository;
        }

        public void Add(Book book)
        {
            _bookRentrRepository.Add(book);
        }

        public List<Book> GetBooksRent()
        {
           return _bookRentrRepository.GetAll();
        }
    }
}
