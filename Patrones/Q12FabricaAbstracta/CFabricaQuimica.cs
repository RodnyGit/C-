using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q12FabricaAbstracta
{
    class CFabricaQuimica:IFabrica
    {
        IProductoLeche leche;
        IProductoSaborizante sabor;

        public IProductoLeche ObtenProductoLeche { get { return leche; } }

        public IProductoSaborizante ObtenSabor { get { return sabor; } }

        public void CrearProducto()
        {
            Console.WriteLine("Estamos produciendo tu malteada");
            leche = new CLecheVaca();
            sabor = new CSaborChocolate();
        }
    }
}
