using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q14Templates
{
    class CBarato : IPrimitiva
    {

        public double Decorar(int cantidad)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Decorando");
            }
            return cantidad * 1.3;
        }

        public double Empacar(int cantidad)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Empacando");
            }
            return cantidad * 0.3;
        }
    }
}
