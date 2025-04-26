
using tikeck.Abstract;
using tikeck.Models;
using tikeck.Models.Enum;

namespace tikeck.Utils
{
    public class LoadData
    {
        static Developer developer;
        static Developer developer2;
        public static void CargarDatosIniciales(SystemTikect sistema)
        {

            List<Comment> comments = new List<Comment>()
            {
               new Comment("LOREFDFD","DFDFDFD"),
               new Comment("DFDFDF","DSFDFDFDFDF"),

            };


            List<Ticket> tickets = new List<Ticket>()
            {
                new Ticket
                {
                    AssignedTo = developer,
                    ReporteBy = "",
                    Comments = comments,
                    CreateDate = DateTime.Now,
                    LastUpdated = DateTime.Now,
                    Priority = Priority.HIGH,
                    Status = StatusTicket.Active,
                },

                new Ticket
                {
                    AssignedTo = developer2,
                    ReporteBy = "",
                    Comments = comments,
                    CreateDate = DateTime.Now,
                    LastUpdated = DateTime.Now,
                    Priority = Priority.HIGH,
                    Status = StatusTicket.Active,
                }
            };

            developer = new Developer
            {
                Name = "Andre Antonio",
                Gender = Gender.Male,
                Dni = "9887787",
                Direction = "",
                Age = 20,
                Role = RoleDeveloper.CiberSecurity,
                AssingTickect = tickets,
            };

            developer2 = new Developer
            {
                Name = "mark diaz",
                Gender = Gender.Male,
                Dni = "723413441",
                Direction = "",
                Age = 30,
                Role = RoleDeveloper.FullStack,
                AssingTickect = tickets,
            };

            sistema.AddDeveloper(developer);
            sistema.AddDeveloper(developer2);
            
            sistema.AddTicket(tickets[0]);
            sistema.AddTicket(tickets[1]);
            
           
            

        }
    }
}
