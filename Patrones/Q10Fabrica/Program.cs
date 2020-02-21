using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q10Fabrica
{
    class Program
    {
        static void Main(string[] args)
        {
            IAutomovil vehiculo = CFabrica.CrearVeiculo("bici");

            Console.WriteLine(vehiculo.Arrancar());

            Console.ReadKey();
        }
    }
}
