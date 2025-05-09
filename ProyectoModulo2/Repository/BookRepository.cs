﻿using ProyectoModulo2.Models;
using ProyectoModulo2.Models.Abstact;
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
        private List<Order> _orders = new List<Order>();

        private int next_id = 1;

        public BookRepository()
        {
            _books.Add(new Book 
            { Id = next_id++,
              Title = "the hobbit",
              Author = "J.R.R Tolkien",
              GenderBook = GenderBook.Fantasy,
              Description = "is a fantasy novel by the British philologist and writer J. R. R. Tolkien.",
              
              
            });
            _books.Add(new Book
            {
                Id = next_id++,
                Title = "Lord of the rings ",
                Author = "J.R.R Tolkien",
                GenderBook = GenderBook.Fantasy,
                Description = "is a fantasy novel by the British philologist and writer J. R. R. Tolkien."
            });
            _books.Add(new Book
            {
                Id = next_id++,
                Title = "it",
                Author = "stephen king",
                GenderBook = GenderBook.Horror,
                Description = "is a fantasy novel  and writer stephen king"
            });
            _books.Add(new Book
            {
                Id = next_id++,
                Title = "american gods",
                Author = "neil gaiman",
                GenderBook = GenderBook.Fantasy,
                Description = "is a fantasy novel by the British philologist and writer neil gaiman"
            });
            _books.Add(new Book
            {
                Id = next_id++,
                Title = "the lord of the ring two towers",
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

        public List<Order> GetBookOrder(int bookId)
        {
            return _orders.Where(o => o.IdBook == bookId).ToList();
        }
    }
}
