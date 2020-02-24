using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q12FabricaAbstracta
{
    class CSaborChocolate : IProductoSaborizante
    {
        public string Informacion()
        {
            return "Sabor a Chocolate";
        }

        public void Obtener()
        {
            Console.WriteLine("Se Produce C7H8N402");
        }
    }
}
