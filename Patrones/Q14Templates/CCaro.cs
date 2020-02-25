using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q14Templates
{
    class CCaro : IPrimitiva
    {
        public double Decorar(int cantidad)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hacer {0} veces", cantidad);
            Console.WriteLine("Pintar Logotipo");
            Console.WriteLine("Poner Brillos");
            Console.WriteLine("Adicionar Cromos");

            return cantidad * 3;
        }

        public double Empacar(int cantidad)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Hacer {0} veces", cantidad);
            Console.WriteLine("Preparar Caja");
            Console.WriteLine("Poner Instructivo");
            Console.WriteLine("Poner Garantia");
            Console.WriteLine("Sellar Empaque");

            return cantidad * 5;
        }
    }
}
