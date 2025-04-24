


using ProyectosBootcamp.Interfaces;
using ProyectosBootcamp.Models;
using System.Threading.Channels;

SystemManagement systemManagement = new SystemManagement();


InitData(systemManagement);



bool isValid = false;

while (!isValid)
{
    Console.WriteLine("main menu");

    Console.WriteLine("1. Gestion de orders book");
    Console.WriteLine("2. Gestion de Readers");
    
    Console.WriteLine("0. Salir");

    Console.WriteLine("\n Seleccione una opcion: ");


    int opcion = int.Parse(Console.ReadLine());
    
    switch (opcion)
    {
        case 1:
            AdmOrders(systemManagement);
            break;
        case 2:
            AdmReaders(systemManagement);
            break;

        default:
            Console.WriteLine("Opcion invalida.");
            break;
    }


}

void InitData(SystemManagement systemManagement)
{
     OrderBook orderBook = new Book("El hobbit", "9877232-9887", GenderBook.Fantasy, DateTime.Now);

     OrderBook orderBook2 = new Book("Game of thrones", "100334-12313", GenderBook.Fantasy, DateTime.Now);

     systemManagement.AddOrders(orderBook);

     systemManagement.AddOrders(orderBook2);

     Reader reader1 = new Reader(20, "max");

     Reader reader2 = new Reader(40, "kas");

     systemManagement.AddReaders(reader1);
     
}
void AdmOrders(SystemManagement systemManagement)
{
    bool regresar = false;
    while (!regresar)
    {
        Console.WriteLine("\nGestion de orders: ");
        Console.WriteLine("\nSeleccione una opcion: ");
        Console.WriteLine("1. Agregar una order");
        Console.WriteLine("2. Ver lista de orders");
        Console.WriteLine("3. Ver order por Id");
        Console.WriteLine("4. Mostrar lista de tipos de order");
        Console.WriteLine("0. Regresar al menu principal");

        string opcion = Console.ReadLine();

        switch (opcion)
        {
            case "1":
                AddOrderBook(systemManagement);
                break;
            case "2":
                ShowOrder(systemManagement );
                break;
            case "3":
                ShowOrderById(systemManagement);
                break;
            case "0":
                regresar = true;
                break;
            default:
                Console.WriteLine("Opcion invalida.");
                break;
        }
    }
}

void ShowOrderById(SystemManagement systemManagement)
{
    throw new NotImplementedException();
}

void ShowOrder(SystemManagement systemManagement)
{
    
    systemManagement.ShowListOrders(systemManagement.GetListOrders());
}

void AddOrderBook(SystemManagement systemManagement)
{
    Console.WriteLine("\nagrega una nueva order");
    Console.Write("nombre del libro");

    string nameBook = Console.ReadLine();

    var orderBooks = systemManagement.GetListOrders();

    if(orderBooks.Count == 0)
    {
        Console.WriteLine("no hay order book");
    }

    Console.WriteLine("order disponibles");

    for (int i = 0; i < orderBooks.Count; i++)
    {
        Console.WriteLine($" name book {orderBooks[i].Name}");
        Console.WriteLine($" nro order {orderBooks[i].NroOrder}");
    }
}

void AdmReaders(SystemManagement systemManagement)
{
    throw new NotImplementedException();
}