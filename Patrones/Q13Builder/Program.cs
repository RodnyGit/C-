using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q13Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Auto Pedorro");
            Console.WriteLine("");
            CDirector director = new CDirector();

            CBuildBase buildBase = new CBuildBase();

            director.Construye(buildBase);

            CProducto auto = buildBase.EnsamblarProducto();

            auto.Detalles();

            Console.WriteLine("---------------------");
            Console.WriteLine("Auto Chevere");
            Console.WriteLine("");

            CBuildSuperior buildSuperior = new CBuildSuperior();

            director.Construye(buildSuperior);

            CProducto auto2 = buildSuperior.EnsamblarProducto();

            auto2.Detalles();

            Console.ReadLine();
        }
    }
}
