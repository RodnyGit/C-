using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4Bridge
{
    class CImp2 : IBridge
    {
        public string CantidadProductos(Dictionary<string, double> productos)
        {
            int cant = 0;
            foreach (var item in productos)
            {
                cant++;
            }
            return ("CImp2 tiene " + Convert.ToString(cant) + " productos cada uno con un impuesto de iva");
        }

        public double MostrarTotal(Dictionary<string, double> productos)
        {
            double suma = 0;
            foreach (var item in productos)
            {

                suma += item.Value + item.Value * 0.22;
            }
            return suma;
        }
    }
}
