using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q12FabricaAbstracta
{
    class Program
    {
        static void Main(string[] args)
        {
            IFabrica miFabrica = new CFabricaQuimica();
            miFabrica.CrearProducto();

            IProductoLeche miLeche = miFabrica.ObtenProductoLeche;
            IProductoSaborizante miSabor = miFabrica.ObtenSabor;

            miLeche.Producir();
            miSabor.Obtener();

            Console.WriteLine("Mi malteada es de {0} y {1}", miLeche.ObtenerDatos(), miSabor.Informacion());
            Console.WriteLine("-------");

            miFabrica = new CFabricaNatural();
            miFabrica.CrearProducto();
            miLeche = miFabrica.ObtenProductoLeche;
            miSabor = miFabrica.ObtenSabor;


            Console.WriteLine("Mi Bebida es de {0} y {1}", miLeche.ObtenerDatos(), miSabor.Informacion());

            Console.ReadKey();
        }
    }
}
