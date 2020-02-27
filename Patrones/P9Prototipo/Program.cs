using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P9Prototipo
{
    class Program
    {
        static void Main(string[] args)
        {
            CAdminProtos adminProtos = new CAdminProtos();
            List<string> nombres = adminProtos.nombresProtos();
            foreach (string item in nombres)
            {
                Console.WriteLine(item);
            }
            Console.Write("Listo");
            Console.ReadKey();
        }
    }
}
