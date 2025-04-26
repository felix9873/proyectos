using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tikeck.Services
{
    public interface ITicketService
    {
        void AddTicket(SystemTikect system);

        void ShowTicket(SystemTikect system);

        void ShowTicketById(SystemTikect system);   
    }
}
