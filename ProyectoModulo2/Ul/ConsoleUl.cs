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
            ChooseTypePerson();
        }

        public void EmployeeMenu()
        {
            Console.WriteLine("\n=== Main Menu ===");
            Console.WriteLine("1. management book");
            Console.WriteLine("2. management client");
            
            Console.WriteLine("0. Exit");
            Console.Write("Enter option: ");

            while (_isRunning)
            {
               
                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        ManagementBook();
                        break;
                    case "2":
                        ManagementClient();
                        break;
                    case "0":
                        _isRunning = false;
                        Console.WriteLine("Thank you for using the System!");
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

        private void   ManagementClient()
        {
            while (_isRunning)
            {
                Console.WriteLine("\n=== Management client ===");
                Console.WriteLine("1.add client");
                Console.WriteLine("2.update book");
                Console.WriteLine("3 view client");
                Console.WriteLine("4.delete book");
                Console.WriteLine("0.Exit");
                Console.Write("Enter option: ");

                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        AddBooK();
                        break;
                    case "2":
                        UpdatedBook();
                        break;
                    case "3":
                        ViewClients();
                        break;
                    case "4":
                        DeleteBook();
                        break;
                    case "0":
                        _isRunning = false;
                        Console.WriteLine("Thank you for using the System!");
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

        private void ViewClients()
        {
           Console.WriteLine("clients");

           var clients = _ClientService.GetClients();

           if(clients.Count == 0)
           {
                Console.WriteLine("no hay cliente");
                return;
           }

           foreach (var client in clients)
           {
                Console.WriteLine(client);
           }

        }

        private void ManagementBook()
        {
            

            while (_isRunning)
            {
                Console.WriteLine("\n=== Management book ===");
                Console.WriteLine("1.add book");
                Console.WriteLine("2.update book");
                Console.WriteLine("3 view Books");
                Console.WriteLine("4.delete book");
                Console.WriteLine("0.Exit");
                Console.Write("Enter option: ");

                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        AddBooK();
                        break;
                    case "2":
                        UpdatedBook();
                        break;
                    case "3":
                        ViewAllBooks();
                        break;
                    case "4":
                        DeleteBook();
                        break;
                    case "0":
                        _isRunning = false;
                        Console.WriteLine("Thank you for using the System!");
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

        private void DeleteBook()
        {
            Console.WriteLine("ingresa el id del libro a eliminar");

            int id = Convert.ToInt32(Console.ReadLine());

            var book = _bookService.GetBookById(id);

            _bookService.Delete(book);

            Console.WriteLine($"libro eliminado con id {id}");
        }

        private void UpdatedBook()
        {
            Console.WriteLine("update libro");
            Console.Write("ingresa el id del libro: ");

            var idBook = Convert.ToInt32(Console.ReadLine());
            var bookFromId = _bookService.GetBookById(idBook);

            Console.Write("ingresa el titulo: ");

            string title = Console.ReadLine();

            Console.WriteLine("ingresa el author: ");

            string author = Console.ReadLine();

            Console.Write("ingresa el genero horror, romance, history,fantasy, sci fi");
            string genderBook = Console.ReadLine().ToLower();

            GenderBook gender = GenderBook.Horror;

            switch (genderBook)
            {
                case "horror":
                    gender = GenderBook.Horror;
                    break;
                case "fantasy":
                    gender = GenderBook.Fantasy;
                    break;
                case "romance":
                    gender = GenderBook.Romance;
                    break;
                case "history":
                    gender = GenderBook.History;
                    break;
                case "sci fi":
                    gender = GenderBook.Sci_fi;
                    break;

            }

            var book = new Book
            {
                Id = bookFromId.Id,
                Title = title,
                Author = author,
                GenderBook = gender,
            };

            _bookService.Updated(book);

            Console.WriteLine(bookFromId);
        }

        private void ViewAllBooks()
        {
           var books =   _bookService.GetBooks();

            foreach (var book in books) 
            {
                Console.WriteLine(book);
            }

        }
        private void AddBooK()
        {
            Console.Write("titulo del libro");
            string title = Console.ReadLine().ToLower();

            Console.Write("author del libro");
            string author = Console.ReadLine().ToLower();

            string genderBook = Console.ReadLine().ToLower();

            GenderBook gender = GenderBook.Horror;

            switch(genderBook)
            {
                case "horror":
                    gender = GenderBook.Horror;
                    break;
                case "fantasy":
                    gender = GenderBook.Fantasy;
                    break;
                case "romance":
                    gender = GenderBook.Romance;
                    break;
                case "history":
                    gender = GenderBook.History;
                    break;
                case "sci fi":
                    gender = GenderBook.Sci_fi;
                    break;

            }
            
            _bookService.GetOrCreateBook(title, author, gender);
        }

        public void ClientMenu()
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
                    case "0":
                        _isRunning = false;
                        Console.WriteLine("Thank you for using the rent book System!");
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



        public void ChooseTypePerson()
        {
            Console.WriteLine("ingresa si eres cliente o colaborador");

            Console.Write("ingresa: ");
            var opcion = Console.ReadLine();

            switch (opcion)
            {
                case "cliente":
                    ClientMenu();
                    break;
                case "colaborador":
                    EmployeeMenu();
                    break;
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

            Console.WriteLine("ingresa tus datos para confimar");

            Console.Write("ingresa tu nombre: ");

            var name = Console.ReadLine().ToLower();

            Console.Write("ingresa tu numero de telefono: ");

            var phone = Console.ReadLine().ToLower();

            var dni = Console.ReadLine().ToLower();

            var email = Console.ReadLine().ToLower();

            _ClientService.GetOrCreateClient(name,phone,email,dni);
           
        }

        private void DisplayMenu()
        {
            Console.WriteLine("\n=== Main Menu ===");
            Console.WriteLine("1. add book to rent");
            Console.WriteLine("2. View rented book");
            Console.WriteLine("3. view orders");
            Console.WriteLine("0. Exit");
            Console.Write("Enter option: ");
        }
    }
}
