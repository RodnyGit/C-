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

            //CRamdomWord palabra = new CRamdomWord("aae");            
            //Console.WriteLine(((CRamdomWord)palabra.Clonar()).Vueltas);
            //Console.WriteLine(palabra.Vueltas);
            CCalcularPalabra palabraNumber = new CCalcularPalabra(698789587);
            Console.WriteLine(palabraNumber.CreatedWord);

            Console.ReadKey();
        }
    }
}
