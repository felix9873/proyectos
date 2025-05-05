using ProyectoModulo2.Models;
using ProyectoModulo2.Models.Abstact;
using ProyectoModulo2.Models.Enum;
using ProyectoModulo2.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoModulo2.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        private readonly IOrderRepository _orderRepository;
        public BookService(IBookRepository bookRepository, IOrderRepository orderRepository)
        {
            _bookRepository = bookRepository;
            _orderRepository = orderRepository;
        }
        public Book GetOrCreateBook(string title, string author, GenderBook genderBook)
        {
            var book = _bookRepository.GetByTitle(title);

            if (book == null)
            {
                book = new Book
                {
                    Title = title,
                    Author = author,
                    GenderBook = genderBook
                };
                _bookRepository.Add(book);
            }
            return book;
        }
        public Book GetBookById(int id) => _bookRepository.GetById(id);
      
        public List<Book> GetBooks() => _bookRepository.GetAll();
        
        public Book GetBookByTitle(string title) => _bookRepository.GetByTitle(title);
        
        public List<Order> GetBookOrder(int bookId) =>  _orderRepository.GetOrdeByBook(bookId);

        public void Add(Book book)
        {
            _bookRepository.Add(book);
        }

        public void Updated(Book book)
        {
            _bookRepository.Update(book);
        }

        public void Delete(Book book)
        {
           _bookRepository.Delete(book);
        }
    }
}
