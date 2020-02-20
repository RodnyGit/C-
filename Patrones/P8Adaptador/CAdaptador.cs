using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P8Adaptador
{
    class CAdaptador : ITarget
    {
        CAdaptado intancia = new CAdaptado();
        public int sumar(int a, int b)
        {
            int[] valores = { a, b };
            double res= intancia.Sumar(valores);
            return (int)res;
        }
        
    }
}
