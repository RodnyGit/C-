using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q12FabricaAbstracta
{
    class CLecheCoco : IProductoLeche
    {
        public string ObtenerDatos()
        {
            return "Leche natual de coco. 250ml";
        }

        public void Producir()
        {
            Console.WriteLine("Moliendo los cocos");
        }
    }
}
