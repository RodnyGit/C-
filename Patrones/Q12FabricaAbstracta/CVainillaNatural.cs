using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q12FabricaAbstracta
{
    class CVainillaNatural : IProductoSaborizante
    {
        public string Informacion()
        {
            return "Extracto natural de vainilla";
        }

        public void Obtener()
        {
            Console.WriteLine("Se extrae de las vainas");
        }
    }
}
