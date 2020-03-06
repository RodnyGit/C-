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
            adminProtos.objetoNuevo += (sender, e) =>
            {
                if (e.Objeto is CCalcularPalabra)
                {
                    CCalcularPalabra objeto = (CCalcularPalabra)e.Objeto;
                    Console.WriteLine("Esta es la palabra creada " + objeto.CreatedWord);
                }
                if (e.Objeto is CRamdomWord)
                {
                    CRamdomWord objeto = (CRamdomWord)e.Objeto;
                    Console.WriteLine("Estas fueron los ciclos para encontrar coincidencia " + objeto.Vueltas);
                }
            };
            foreach (string item in nombres)
            {
                Console.WriteLine(item);
            }
            Console.Write("Listo \n");
            Console.ReadKey();
        }
    }
}
