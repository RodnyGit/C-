using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q11Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            CSingleton objeto1 = CSingleton.crearSingleton("Rodney", 07729);
            CSingleton objeto2 = CSingleton.crearSingleton("pedro", 02329);

            Console.WriteLine(objeto1.Nombre);
            Console.WriteLine(objeto2.Nombre);

            Console.ReadKey();


        }
    }
}
