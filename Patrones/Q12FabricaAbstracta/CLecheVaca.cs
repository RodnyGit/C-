using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q12FabricaAbstracta
{
    class CLecheVaca : IProductoLeche
    {
        public string ObtenerDatos()
        {
            return "Leche pura de vaca, 250";
        }

        public void Producir()
        {
            Console.WriteLine("Ordeñando la vaca");
        }
    }
}
