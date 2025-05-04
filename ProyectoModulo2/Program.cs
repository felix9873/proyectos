

using ProyectoModulo2.Models;
using ProyectoModulo2.Repository;
using ProyectoModulo2.Services;
using ProyectoModulo2.Ul;
using System.Net.Http.Headers;


var bookService = new BookService(new BookRepository(), new OrdeRepository());
var employeService = new EmployeeService(new EmployeeRepository());
var orderService = new OrderService(new OrdeRepository());
var clientService = new ClientService(new ClientRepository(), new OrdeRepository() );
var bookRentService = new BookRentSevice(new BookRentRepository());

var ui = new ConsoleUl(clientService, bookService, orderService, employeService, bookRentService);

ui.Run();