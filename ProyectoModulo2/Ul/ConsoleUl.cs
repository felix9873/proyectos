using ProyectoModulo2.Models;
using ProyectoModulo2.Models.Abstact;
using ProyectoModulo2.Models.Enum;
using ProyectoModulo2.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoModulo2.Ul
{
    public class ConsoleUl
    {
        private readonly IClientService _ClientService;
        private readonly IBookService _bookService;
        private readonly IOrderService _orderService;
        private readonly IEmployeeService _employeeService;
        private readonly IBookRentService _bookRentService;


        private bool _isRunning = true;
        public ConsoleUl(IClientService clientService
            , IBookService bookService , IOrderService orderService,
            IEmployeeService employeeService , IBookRentService bookRentService) 
        {
            _ClientService = clientService;
            _bookRentService = bookRentService;
            _bookService = bookService;
            _orderService = orderService;
            _employeeService = employeeService;
        }

        public void Run()
        {
            Console.WriteLine("===  Rent book system ===");

            while (_isRunning)
            {
                DisplayMenu();

                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        AddBooKRent();
                        break;
                    case "2":
                        ViewRentedBooks();
                        break;
                    case "3":
                        ViewOrders();
                        break;
                    case "4":
                     
                        break;
                    case "5":
                        
                        break;
                    case "0":
                        _isRunning = false;
                        Console.WriteLine("Thank you for using the Restaurant Reservation System!");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }

                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        private void ViewOrders()
        {

            var orders  = _orderService.GetOrders();

            if(orders.Count == 0)
            {
                Console.WriteLine("no tienes orders");
                return;
            }

            foreach (var order in orders) 
            {
                Console.WriteLine(order);
            }
        }

        private void ViewRentedBooks()
        {
            
            Console.WriteLine();
            Console.WriteLine("rented books");

            var rentedBooks = _bookRentService.GetBooksRent();

            if(rentedBooks.Count == 0)
            {
                Console.WriteLine("no tienes libros rentados");
                return;
            }
            

            foreach (var book in rentedBooks)
            {
                Console.WriteLine(book);
            }
        }

        private void AddBooKRent()
        {
            Console.Clear();
            Console.WriteLine("=== Book ===");

            var books = _bookService.GetBooks();

            foreach (var book in books)
            {
                Console.WriteLine(book);
            }

            Console.Write("ingresa el id del libro que quieres rentar: ");

            var idBook = Convert.ToInt32(Console.ReadLine());
            var bookFromId = _bookService.GetBookById(idBook);

            Console.WriteLine("los metodos de pago son Plin, efectivo , tarjeta de credito");
            Console.Write("ingresa el tipo de pago ");
            var typePayment = Console.ReadLine().ToLower();

            Console.WriteLine("ingresa si es renta o compra");

            var typeOrder = Console.ReadLine().ToLower();

            TypeOrder type = TypeOrder.Rent; 

            switch(typeOrder)
            {
                case "renta":
                    type = TypeOrder.Rent;
                    break;
                case "compra":
                    type = TypeOrder.Purchase;
                    break;
            }

            Payment payment = new PlinPayment();
            switch(typePayment)
            {
                case "plin":
                    payment = new PlinPayment 
                    { 
                        TypePayment = TypePayment.Plin
                    };
                    break;
                case "efectivo":
                    payment = new CashPayment 
                    {
                        TypePayment = TypePayment.Cash
                    };
                    break;
                case "tarjeta de credito":
                    payment = new CreditCard
                    { 
                        TypePayment = TypePayment.CreditCard
                    };
                    break;
                   
            }

            var order = new OrderRent()
            {
                IdBook  = bookFromId.Id,

                AssignToPayment = payment,

                fechOrder = DateTime.Now,

                TypeOrder = type,
                
            };

            _orderService.Add(order);

            if(bookFromId != null)
            {
                Console.WriteLine($" add rent book with id {bookFromId.Id}");
                _bookRentService.Add(bookFromId);

            }
            else
            {
                Console.WriteLine($"el libro no existe ");
            }

            order.AssignToPayment = payment;

        }

        private void DisplayMenu()
        {
            Console.WriteLine("\n=== Main Menu ===");
            Console.WriteLine("1. add book to rent");
            Console.WriteLine("2. View rented book");
            Console.WriteLine("3. view orders");
            Console.WriteLine("4. view employe");
            
            Console.WriteLine("0. Exit");
            Console.Write("Enter option: ");
        }
    }
}
