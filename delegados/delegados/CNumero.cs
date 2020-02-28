using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace delegados
{
    static class CNumero
    {
        public static List<int> Pares(int numero, Action<int> SubscribirYProbarFunciones)
        {
            int i = 1;
            List<int> salida = new List<int>();
            while (i < numero)
            {
                SubscribirYProbarFunciones(i);
                if (i % 2 == 0)
                    salida.Add(i);
                Thread.Sleep(2000);
                i++;
            }
            return salida;
        }
    }
}
