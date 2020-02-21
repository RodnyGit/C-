using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q11Singleton
{
    class CSingleton
    {
        private string nombre;
        private int id;
        private static CSingleton instanciado;

        private CSingleton(string nombre, int id)
        {
            this.nombre = nombre;
            this.id = id;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Id { get => id; set => id = value; }

        static public CSingleton crearSingleton(string nombre, int id)
        {
            if (instanciado == null)
            {
                instanciado = new CSingleton(nombre, id);

                return instanciado;
            }
            return instanciado;
        }
    }
}
