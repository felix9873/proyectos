


using ProyectosBootcamp.Interfaces;
using ProyectosBootcamp.Models;


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

     OrderBook orderBook3 = new Book("It", "955656-1443443" , GenderBook.Horror, DateTime.Now);

     systemManagement.AddOrders(orderBook);

     systemManagement.AddOrders(orderBook2);

     systemManagement.AddOrders(orderBook3);

     Reader reader1 = new Reader(20, "max", orderBook);

     Reader reader2 = new Reader(40, "kas", orderBook);

   
     systemManagement.AddReaders(reader1);
     systemManagement.AddReaders(reader2);
     
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
    Console.Write("ingresa el id de la order: ");

    int id = Convert.ToInt16( Console.ReadLine());

    Console.WriteLine($"name book {systemManagement.GetOrderById(id).Name}");
    Console.WriteLine($"id book {systemManagement.GetOrderById(id).Id}");
    Console.WriteLine($"nro order book {systemManagement.GetOrderById(id).NroOrder}");
    Console.WriteLine($"fech book {systemManagement.GetOrderById(id).FechOrder}");
    Console.WriteLine($"gender book {systemManagement.GetOrderById(id).GenderBook}");
}

void ShowOrder(SystemManagement systemManagement)
{
    
    systemManagement.ShowListOrders(systemManagement.GetListOrders());
}

void AddOrderBook(SystemManagement systemManagement)
{
    Console.WriteLine("\nagrega una nueva order");
    Console.Write("nombre del libro:  ");

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

    Console.Write("nro order book: ");
    string nroOrderBook = Console.ReadLine();

    Console.WriteLine("gender: horror  - fantasy  - scifi  - romance");

    Console.Write("ingresa el genero del libro: ");

    string genderBook = Console.ReadLine().ToLower();

    GenderBook gender = GenderBook.Default;

    switch (genderBook)
    {
        case "horror":
            gender = GenderBook.Horror;
            break;
        case "fantasy":
            gender = GenderBook.Fantasy;
            break;
        case "scifi":
            gender = GenderBook.Scifi;
            break;
        case "romace":
            gender = GenderBook.Romance;
            break;
        default:
            Console.WriteLine("ingresa un genero valido");
            break;
    }

    OrderBook orderBook = new Book(nameBook,nroOrderBook, gender, DateTime.Now);


    systemManagement.AddOrders(orderBook);


    Console.WriteLine(  $" order book added with id:  {orderBook.Id}");



}

void AdmReaders(SystemManagement systemManagement)
{
    bool regresar = false;

    while (!regresar) 
    {
        Console.WriteLine("\nGestion de orders: ");
        Console.WriteLine("\nSeleccione una opcion: ");
        Console.WriteLine("1. Agregar una order");
        Console.WriteLine("2. Ver lista de orders");
        Console.WriteLine("3. Ver order por Id");
        Console.WriteLine("0. Regresar al menu principal");

        string opcion = Console.ReadLine();

        switch (opcion)
        {
            case "1":
                AddReader(systemManagement);
                break;
            case "2":
                ShowReaders(systemManagement);
                break;
            case "3":

                break;
            case "0":

                break;
        }
    }
}

void ShowReaders(SystemManagement systemManagement)
{
    for(int i = 0; i < systemManagement.GetListOrders().Count; i++) 
    {
        Console.WriteLine(systemManagement.GetListOrders()[i].Name);
    }
}

void AddReader(SystemManagement systemManagement)
{
    Console.WriteLine("\nadd reader");

    Console.Write("name reader: ");

    string name = Console.ReadLine();

    Console.WriteLine("age reader: ");

    int age = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("ingrese el id de la order para agregar");

    int id = Convert.ToInt32(Console.ReadLine());

    var orden =  systemManagement.GetOrderById(id);

    var reader = new Reader(age, name, orden);

    systemManagement.AddReaders(reader);

    Console.WriteLine("reader added");
}