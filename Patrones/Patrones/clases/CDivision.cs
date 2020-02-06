using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1Estrategia
{
    class CDivision : IEstrategia
    {
        public double Operacion(double v1, double v2)
        {
            return v1 / v2;
        }

    }
}
