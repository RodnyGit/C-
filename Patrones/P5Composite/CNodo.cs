using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5Composite
{
    class CNodo : INodo
    {
        private string nombre;
        private CNodo padre;
        private List<INodo> hijos = new List<INodo>();

        public string Nombre { get => nombre; }
        internal List<INodo> Hijos { get => hijos; }
        public CNodo(string nombre, CNodo padre, List<INodo> hijos)
        {
            this.nombre = nombre;
            this.padre = padre;
            this.hijos = hijos;
        }

        public CNodo(string nombre, CNodo padre)
        {
            this.nombre = nombre;
            this.padre = padre;
        }

        public CNodo()
        {
            this.nombre = "root";
        }

        public INodo AddNodo(INodo nodo)
        {
            this.hijos.Add((CNodo)nodo);
            return this;
        }

        public INodo Buscar(INodo nodo)
        {
            CNodo encontrado = null;
            foreach (CNodo item in hijos)
            {
                if (encontrado == null)
                {
                    if (item == nodo)
                    {
                        encontrado = item;
                        break;
                    }
                    else
                    {
                        encontrado = (CNodo)item.Buscar(nodo);
                    }
                }
            }
            return encontrado;
        }

        public List<INodo> Hermanos()
        {
            CNodo padre = this.padre;
            padre.Remover(this);
            List<INodo> hermanos = padre.hijos;
            return hermanos;
        }

        public int Nivel()
        {
            int nivel = 0;
            if (this.padre.nombre != "root")
            {
                nivel++;
                return nivel + this.padre.Nivel(); ;
            }
            else
            {
                return 1;
            }
        }

        public INodo Padre()
        {
            return this.padre;
        }

        public INodo Remover(INodo nodo)
        {
            CNodo enoncontrado = (CNodo)Buscar(nodo);
            CNodo padre = (CNodo)enoncontrado.Padre();
            padre.hijos.Remove(enoncontrado);
            return padre;
        }
    }
}
