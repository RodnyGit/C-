using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4Bridge
{
    class CAbstraccion
    {
        private IBridge imp;
        private Dictionary<string, double> productos;

        public CAbstraccion(IBridge imp, Dictionary<string, double> productos)
        {
            this.imp = imp;
            this.productos = productos;
        }

        public CAbstraccion(int opc, Dictionary<string, double> productos)
        {
            switch (opc)
            {
                case 1:
                    {
                        imp = new CImp1();
                    }
                    break;
                case 2:
                    {
                        imp = new CImp2();
                    }
                    break;
                case 3:
                    {
                        imp = new CImp3();
                    }
                    break;
                default:
                    break;
            }
            this.productos = productos;
        }
        public void Mostrar()
        {
            Console.WriteLine(imp.CantidadProductos(productos));
            Console.WriteLine("Este es el costo total "+Convert.ToString(imp.MostrarTotal(productos)));
        }
    }
}
