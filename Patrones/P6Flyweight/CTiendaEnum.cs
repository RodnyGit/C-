using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P6Flyweight
{
    class CTiendaEnum : IEnumerator
    {
        List<CAuto> lista;

        int pos = -1;

        public CTiendaEnum(List<CAuto> lista)
        {
            this.lista = lista;
        }

        public object Current => lista[pos];

        public bool MoveNext()
        {
            pos++;
            if (lista.Count > pos)
                return true;
            return false;
        }

        public void Reset()
        {
            this.pos = -1;
        }
    }
}
