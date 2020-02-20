using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P9Prototipo
{
    class CRamdomWord : IPrototipo
    {
        private string palabra;
        private int vueltas = 0;
        private char[] vocales = { 'a', 'e', 'i', 'o', 'u' };
        public string Palabra { get => palabra; set => palabra = value; }
        public int Vueltas { get => vueltas; set => vueltas = value; }

        public CRamdomWord()
        {
        }

        public CRamdomWord(string palabra)
        {
            this.palabra = palabra;
            string encontrada = "";
            bool salida = false;
            while (!salida)
            {
                Random random = new Random();
                while (encontrada.Count() < palabra.Count())
                {
                    encontrada += vocales[random.Next(4)];
                }
                vueltas++;
                if (encontrada == palabra)
                    salida = true;
                encontrada = "";
            }
        }

        public object Clonar()
        {
            CRamdomWord clon = new CRamdomWord();
            clon.palabra = palabra;
            clon.vueltas = vueltas;
            clon.vocales = vocales;
            vueltas++;
            return clon;
        }
    }
}
