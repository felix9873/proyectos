
using tikeck.Abstract;
using tikeck.Models;
using tikeck.Models.Enum;

namespace tikeck.Utils
{
    public class LoadData
    {
        
        public static void CargarDatosIniciales(SystemTikect sistema)
        {
            sistema.AddDeveloper(new Developer { Name = "max" , Age = 25, Dni ="8787878"});
            sistema.AddDeveloper(new Developer { Name = "felix", Age = 40, Dni = "9313131" });
            sistema.AddDeveloper(new Developer { Name = "lucia", Age = 20, Dni = "9921211" });
            sistema.AddDeveloper(new Developer { Name = "dante", Age = 15, Dni = "12133131" });

            var ticket1 = new Ticket
            {
                Title = "Login page error",
                Description = "Users are unable to login after the recent update",
                Priority = Priority.MEDIUM,
            };

        }
    }
}
