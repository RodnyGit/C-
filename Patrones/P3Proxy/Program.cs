using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            CRestaurant cocinita = new CRestaurant();

            char opc = 'w';
            int aut = 0;
            while (aut == 0)
            {
                Console.WriteLine("Se sabe el password..??");
                string pass = Console.ReadLine();
                pass = cocinita.autenticacion(pass);
                if (pass == "ok")
                {
                    aut = 1;
                }
                else
                {
                    Console.WriteLine("Ese no es... estas inflando..??");
                }
            }
            while (opc != 's')
            {
                Console.WriteLine("Que desea comer");
                string receta = Console.ReadLine();
                Console.WriteLine("Cuantos platillos desea");
                int cantidad = Convert.ToInt32(Console.ReadLine());

                cocinita.atencion(receta, cantidad);
                Console.WriteLine("Presione s si desea marcharse");
                opc = Convert.ToChar(Console.ReadLine());
            }

        }
    }
}
