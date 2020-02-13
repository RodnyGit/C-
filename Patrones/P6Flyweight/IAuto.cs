using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P6Flyweight
{
    interface IAuto
    {
        double Precio();
        double KmPorLitro();
        bool Liviano();
        bool Economico();
    }
}
