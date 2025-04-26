using ProyectosBootcamp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ProyectosBootcamp.Models
{
    public class Book : OrderBook
    {
        public static int nextid = 1;
        private string _name;
        private int _id = 0;

        private string _nroOrder;

        private GenderBook _genderBook;

        private DateTime _fechOrder;

        public string Name { get => _name; set => _name = value; }
        public string NroOrder { get => _nroOrder; set => _nroOrder = value; }
        public DateTime FechOrder { get => _fechOrder; set => _fechOrder = value; }
        public GenderBook GenderBook { get => _genderBook; set => _genderBook = value; }
        public int Id { get => _id;  }

        public Book(string name, string nroOrder, GenderBook genderBook, DateTime fechOrder)
        {
            _name = name;
            _id = nextid++;
            _nroOrder = nroOrder;
            _genderBook = genderBook;
            _fechOrder = fechOrder;
        }

        public void Order()
        {
            Console.WriteLine("order");
            Console.WriteLine($"id  {Id}");
            Console.WriteLine($"name  {Name}");
            Console.WriteLine($"nroOrder {NroOrder}");
            Console.WriteLine($"fech {FechOrder}");
            Console.WriteLine($"gender {GenderBook}");
            
        }
    }
}
