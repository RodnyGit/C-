using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P9Prototipo
{
    class CCalcularPalabra : IPrototipo
    {
        private char[] letras = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'ñ', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        private int numero;
        private string createdWord;

        public CCalcularPalabra()
        {
        }

        public CCalcularPalabra(int numero)
        {
            createdWord = "";
            this.numero = numero;
            Random random = new Random();
            string arrNumero = Convert.ToString(numero);
            foreach (char item in arrNumero)
            {
                int number = 10;
                while (number > 3)
                {
                    number = random.Next(9999999);
                    if (number < 4)
                    {
                        int n = Convert.ToInt32(item) - 49;
                        number = random.Next(1, 4);
                        if (number == 1)
                            createdWord += letras[n];
                        if (number == 2)
                            createdWord += letras[n * 2];
                        if (number == 3)
                            createdWord += letras[n * 3];
                    }
                }
            }
        }

        public int Numero { get => numero; set => numero = value; }
        public string CreatedWord { get => createdWord; set => createdWord = value; }

        public object Clonar()
        {
            throw new NotImplementedException();
        }
    }
}
