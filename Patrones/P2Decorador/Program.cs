using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2Decorador
{
    class Program
    {
        static void Main(string[] args)
        {
            IDecorador miAuto = new CAuto(250000, "Audi");
            miAuto = new CClaxon(50, "electrico", miAuto);//decoraciones
            miAuto = new CTuboEscape(200, "Buyero", miAuto);//decoraciones
            Console.WriteLine(miAuto.DecirPropiedades() + " y el precio es " + miAuto.CalcularPrecio().ToString());
            Console.ReadKey();
        }
    }
}
