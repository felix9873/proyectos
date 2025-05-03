using ProyectoModulo2.Models.Abstact;
using ProyectoModulo2.Models.Enum;


namespace ProyectoModulo2.Models
{
    public class OrderPurchase : Order
    {
        public TypeOrder TypeOrder { get; set; }
    }
}
