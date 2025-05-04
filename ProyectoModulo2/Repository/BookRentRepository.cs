using ProyectoModulo2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoModulo2.Repository
{
    public class BookRentRepository : IBookRentrRepository
    {
        private readonly List<Book> bookRent = new List<Book>();    
        public void Add(Book entity)
        {
            bookRent.Add(entity);
        }

        public void Delete(Book entity)
        {
            bookRent.Remove(entity);
        }

        public List<Book> GetAll()
        {
            return bookRent;
        }

        public Book GetById(int id)
        {
            return bookRent.FirstOrDefault(b => b.Id == id);
        }

        public void Update(Book entity)
        {
            var index = bookRent.FindIndex(b => b.Id == entity.Id);
            if (index != -1) bookRent[index] = entity;
        }
    }
}
