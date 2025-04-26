using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tikeck.Models;

namespace tikeck.Services
{
   public interface IDeveloperService
   {
        void AddDeveloper(SystemTikect system);
        void ShowDeveloper(SystemTikect system);

        void ShowDeveloperById(SystemTikect system);


   }
}
