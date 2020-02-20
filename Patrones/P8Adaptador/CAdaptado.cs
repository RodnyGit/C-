using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P8Adaptador
{
    class CAdaptado
    {
        public double Sumar(int[] valores) {
            double res = 0;
            foreach (int item in valores)            
                res += item;            
            return res;
        }
    }
}
