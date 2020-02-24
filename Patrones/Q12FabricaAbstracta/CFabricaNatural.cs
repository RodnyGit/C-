using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q12FabricaAbstracta
{
    class CFabricaNatural : IFabrica
    {
        IProductoLeche leche;
        IProductoSaborizante sabor;

        public IProductoLeche ObtenProductoLeche { get { return leche; } }

        public IProductoSaborizante ObtenSabor { get { return sabor; } }

        public void CrearProducto()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Que tipo de leche desea 1)- Almendras 2)- Coco");
            string seleccion = Console.ReadLine();
            if (seleccion == "1")
            {
                leche = new CLecheAlmendras();
            }
            if (seleccion == "2")
            {
                leche = new CLecheCoco();
            }
            leche.Producir();
            Console.WriteLine("Extraemos el sabor");
            sabor = new CVainillaNatural();
            sabor.Obtener();
        }
    }
}
