using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tikeck.Models;

namespace tikeck.Services
{
   public interface IServiceTickect
   {
        void AddTticket(Developer developer);
        void ShowTickect();

        void ShowTicketById();


   }
}
