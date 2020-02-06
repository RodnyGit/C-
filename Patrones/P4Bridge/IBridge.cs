using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4Bridge
{
    interface IBridge
    {
        double MostrarTotal(Dictionary<string, double> productos);
        string CantidadProductos(Dictionary<string, double> productos);
    }
}
