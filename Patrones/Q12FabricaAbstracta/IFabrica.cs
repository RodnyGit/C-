using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q12FabricaAbstracta
{
    interface IFabrica
    {
        void CrearProducto();
        IProductoLeche ObtenProductoLeche { get; }
        IProductoSaborizante ObtenSabor { get; }
    }
}
