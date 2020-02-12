using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5Composite
{
    interface INodo
    {
        INodo AddNodo(INodo nodo);
        INodo Padre();
        INodo Remover(INodo nodo);
        INodo Buscar(INodo nodo);
        List<INodo> Hermanos();
        int Nivel();
    }
}
