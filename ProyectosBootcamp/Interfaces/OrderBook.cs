using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ProyectosBootcamp.Interfaces
{
    public enum GenderBook
    {
        Horror,
        Fantasy,
        Romance,
        Scifi,
        Default
    }

    public interface OrderBook
    {
        int Id { get; }
        public string Name { get; set; }
        string NroOrder { get; set; }
        DateTime FechOrder { get; set; }

        GenderBook GenderBook { get; set; }

        void Order();
    }
}
