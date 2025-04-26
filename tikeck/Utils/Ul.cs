using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tikeck.Services;

namespace tikeck.Utils
{
    public class Ul
    {
        public static void CargarMenuPrincipal(SystemTikect sistema)
        {
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("\nMenu Principal:");
                Console.WriteLine("1. Gestion de ticket");
                Console.WriteLine("2. Gestion de Developer");
                
                Console.WriteLine("0. Salir");

                Console.WriteLine("\n Seleccione una opcion: ");

                try
                {
                    int opcion = int.Parse(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            AdmDeveloper(sistema);
                            break;
                        case 2:
                            GestionProductos(sistema);
                            break;
                        
                        default:
                            Console.WriteLine("Opcion invalida.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

     
        static void AdmDeveloper(SystemTikect sistema)
        {
            bool regresar = false;
            IDeveloperService servicio = new DeveloperService();
            while (!regresar)
            {
                Console.WriteLine("\nGestion de Empleados: ");
                Console.WriteLine("\nSeleccione una opcion: ");
                Console.WriteLine("1. Agregar un empleado");
                Console.WriteLine("2. Ver lista de empleados");
                Console.WriteLine("3. Ver empleado por Id");
               

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        servicio.AddDeveloper(sistema);
                        break;
                    case "2":
                        servicio.ShowDeveloper(sistema);
                        break;
                    case "3":
                        servicio.ShowDeveloperById(sistema);
                        break;
                    default:
                        Console.WriteLine("Opcion invalida.");
                        break;
                }
            }
        }

        static void GestionProductos(SystemTikect sistema)
        {
            bool regresar = false;
            ITicketService servicio = new TIcketService();
            while (!regresar)
            {
                Console.WriteLine("\nGestion de Productos: ");
                Console.WriteLine("\nSeleccione una opcion: ");
                Console.WriteLine("1. Agregar un producto");
                Console.WriteLine("2. Ver lista de productos");
                Console.WriteLine("3. Ver empleado por Id");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        servicio.AddTicket(sistema);
                        break;
                    case "2":
                        servicio.ShowTicket(sistema);
                        break;
                    case "3":
                        servicio.ShowTicketById(sistema);
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
    }
}
