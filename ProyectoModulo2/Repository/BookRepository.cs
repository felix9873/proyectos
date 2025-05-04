using ProyectoModulo2.Models;
using ProyectoModulo2.Models.Enum;
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

        private int next_id = 1;

        public BookRepository()
        {
            _books.Add(new Book 
            { Id = next_id++,
              Title = "el hobbit",
              Author = "J.R.R Tolkien",
              GenderBook = GenderBook.Fantasy,
              Description = "is a fantasy novel by the British philologist and writer J. R. R. Tolkien."
            });
            _books.Add(new Book
            {
                Id = next_id++,
                Title = "el hobbit",
                Author = "J.R.R Tolkien",
                GenderBook = GenderBook.Fantasy,
                Description = "is a fantasy novel by the British philologist and writer J. R. R. Tolkien."
            });
            _books.Add(new Book
            {
                Id = next_id++,
                Title = "el hobbit",
                Author = "J.R.R Tolkien",
                GenderBook = GenderBook.Fantasy,
                Description = "is a fantasy novel by the British philologist and writer J. R. R. Tolkien."
            });
            _books.Add(new Book
            {
                Id = next_id++,
                Title = "el hobbit",
                Author = "J.R.R Tolkien",
                GenderBook = GenderBook.Fantasy,
                Description = "is a fantasy novel by the British philologist and writer J. R. R. Tolkien."
            });
            _books.Add(new Book
            {
                Id = next_id++,
                Title = "el hobbit",
                Author = "J.R.R Tolkien",
                GenderBook = GenderBook.Fantasy,
                Description = "is a fantasy novel by the British philologist and writer J. R. R. Tolkien."
            });
        }
        public List<Book> GetAll()
        {
            return _books;
        }
        public void Add(Book entity)
        {
            entity.Id = next_id++;
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

        public Book GetByTitle(string title)
        {
            return _books.FirstOrDefault(b => b.Title == title);
        }

        

    }
}
