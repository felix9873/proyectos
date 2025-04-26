using ProyectosBootcamp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectosBootcamp.Models
{
    public class SystemManagement
    {
        private List<OrderBook> _orders =  new List<OrderBook>();
        
        private List<Reader> _readers = new List<Reader>();

        public void AddOrders(OrderBook orderBook)
        {
            _orders.Add(orderBook); 
            
        }

        public void AddReaders(Reader reader) 
        { 
            _readers.Add(reader);
        }

        public List<OrderBook> GetListOrders()
        {
            return _orders;
        }

        public List<Reader> GetReaders() 
        { 
            return _readers;
        }

        public OrderBook GetOrderById(int id) 
        {
            return _orders.FirstOrDefault(o => o.Id == id);
        }

        public Reader GetReaderById(int id) 
        {
            return _readers.FirstOrDefault(r => r.Id == id);
        }


        public void ShowListOrders(List<OrderBook> orders) 
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("orders book");
            for (int i = 0; i < orders.Count; i++)
            {
                Console.WriteLine("------------------------");
                Console.WriteLine($" id {orders[i].Id}");
                Console.WriteLine($" name {orders[i].Name}");
                Console.WriteLine($" nroOrder {orders[i].NroOrder}");
                Console.WriteLine($" FechOrder {orders[i].FechOrder}");

                switch(orders[i].GenderBook)
                {
                    case GenderBook.Horror:
                        Console.WriteLine(" Gender book : Horror");
                        break;
                    case GenderBook.Fantasy:
                        Console.WriteLine(" Gender Book : Fantasy");
                        break;
                    case GenderBook.Romance:
                        Console.WriteLine(" Gender Book : Romance");
                        break;
                    case GenderBook.Scifi:
                        Console.WriteLine(" Gender Book : Sci fi");
                        break;
                    default: Console.WriteLine("ingresa un genero valido");
                            break;  
                }

            }
        }


    }
}
