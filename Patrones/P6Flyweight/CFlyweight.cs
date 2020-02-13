using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P6Flyweight
{
    class CFlyweight : IEnumerable
    {
        private List<CAuto> tienda = new List<CAuto>();

        private CAuto FindAuto(CAuto auto)
        {
            foreach (CAuto item in tienda)
                if (item == auto)
                    return item;
            return null;
        }

        public string AdddAuto(CAuto auto)
        {
            CAuto founded = FindAuto(auto);
            if (founded != null)
                return "Ya existe ese modelo de auto";
            tienda.Add(auto);
            return "agregado " + auto.Marca + " modelo " + auto.Modelo;
        }
        public int GetIndex(CAuto auto)
        {
            return tienda.FindIndex(e => e == auto);
        }

        public string RemoveAuto(CAuto auto)
        {
            CAuto founded = FindAuto(auto);
            if (founded == null)
                return "no existe " + auto.Marca + " modelo " + auto.Modelo;
            tienda.Remove(auto);
            return "removido " + auto.Marca + " modelo " + auto.Modelo;
        }
        public CAuto GetAuto(int index)
        {
            return tienda[index];
        }

        public IEnumerator GetEnumerator()
        {
            return new CTiendaEnum(tienda);
        }
    }
}
