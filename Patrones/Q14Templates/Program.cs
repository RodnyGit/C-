using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q14Templates
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad = 0;
            string tipo = "";
            IPrimitiva calidad = null;
            double total = 0;
            Console.WriteLine("1-Barato, 2-Caro");
            tipo = Console.ReadLine();
            switch (tipo)
            {
                case "1":
                    calidad = new CBarato();
                    break;
                case "2":
                    calidad = new CCaro();
                    break;
                default:
                    break;
            }
            Console.WriteLine("Cuantos a producir");
            cantidad = Convert.ToInt32(Console.ReadLine());
            CAlgoritmo produccion = new CAlgoritmo();
            total = produccion.Metodotemplate(calidad, cantidad);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("El total es " + total);
            Console.ReadLine();
        }
    }
}
