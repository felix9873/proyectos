using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoModulo2.Models
{
    public class Order
    {
        public Client AssignOrder {  get; set; }


        public void AssingOrderTo(Client client)
        {
            AssignOrder = client;
        }
    }
}
