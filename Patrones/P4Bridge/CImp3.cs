using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4Bridge
{
    class CImp3 : IBridge
    {
        public string CantidadProductos(Dictionary<string, double> productos)
        {
            int cant = 0;
            foreach (var item in productos)
            {
                cant++;
            }
            return ("CImp2 tiene " + Convert.ToString(cant) + " productos cada uno con un impuesto de iva si el producto vale mas de 50 pesos");
        }

        public double MostrarTotal(Dictionary<string, double> productos)
        {
            double suma = 0;
            foreach (var item in productos)
            {
                if (item.Value > 50)
                {

                    suma += (item.Value + item.Value * 0.22);
                }
                else
                {
                    suma += item.Value;
                }
            }
            return suma;
        }
    }
}
