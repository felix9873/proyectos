using ProyectoModulo2.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoModulo2.Repository
{
    public class BookRepository : IBookRepository
    {
        private List<Book> _books = new List<Book>();
        public List<Book> GetAll()
        {
            return _books;
        }
        public void Add(Book entity)
        {
            _books.Add(entity);
        }

        public Book GetById(int id)
        {
            return _books.FirstOrDefault(b => b.Id == id);
        }
        
        public void Update(Book entity)
        {
            var index = _books.FindIndex(b => b.Id == entity.Id);
            if(index != -1) _books[index] = entity;
        }
        public void Delete(Book entity)
        {
            _books.Remove(entity);
        }

        public List<Book> GetByTitle(string title)
        {
            return _books.Where(b => b.Title == title).ToList();
        }

        

    }
}
