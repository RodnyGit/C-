using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P8Adaptador
{
    class Program
    {
        static void Main(string[] args)
        {
            ITarget calcular = new CAdaptador();
            Console.WriteLine(calcular.sumar(4, 5));
            Console.ReadLine();
        }
    }
}
