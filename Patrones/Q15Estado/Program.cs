using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Q15Estado
{
    class Program
    {
        static void Main(string[] args)
        {
            CCaldera caldera = new CCaldera();


            Task.Run(() =>
            {
                int i = 0;
                while (i == 0)
                {
                    caldera.Trabajar();
                    Console.WriteLine(caldera.ToString());
                    Console.WriteLine("Seleccione una opcion, 1-calentar, 2-apagar, 3-hechar combustible");
                    Thread.Sleep(3000);
                    Console.Clear();
                }
            });
            int c = 0;
            while (c != 4)
            {
                c = Convert.ToInt32(Console.ReadLine());
                switch (c)
                {
                    case 1:
                        caldera.ForzarFuego();
                        break;
                    case 2:
                        caldera.CortarFuego();
                        break;
                    case 3:
                        caldera.PonerCombustible();
                        break;
                    default:
                        break;
                }
            }


            Console.ReadKey();
        }
    }
}
