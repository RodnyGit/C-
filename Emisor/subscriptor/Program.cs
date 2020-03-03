using Division;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subscriptor
{
    class Program
    {
        static void Main(string[] args)
        {
            CDivision division = new CDivision();

            division.ZeroDivisionEventHandler += (sender, e) => Console.WriteLine($"No se puede dividir {e.A}/{e.B}");

            Console.WriteLine(division.Division(2, 0));

            Console.ReadKey();
        }
    }
}
