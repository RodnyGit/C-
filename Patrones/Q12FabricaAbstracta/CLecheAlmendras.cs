using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q12FabricaAbstracta
{
    class CLecheAlmendras : IProductoLeche
    {
        public string ObtenerDatos()
        {
            return "Leche organica de almendras. 250ml";
        }

        public void Producir()
        {
            Console.WriteLine("Procesando almendras");
        }
    }
}
