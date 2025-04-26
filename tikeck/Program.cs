using tikeck;
using tikeck.Utils;

Console.WriteLine("=== Ticket Management System ===\n");

SystemTikect systemTikect = new SystemTikect();

LoadData.CargarDatosIniciales(systemTikect);

Ul.CargarMenuPrincipal(systemTikect);