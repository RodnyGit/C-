using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2Decorador
{
    class CAuto : IDecorador
    {
        private double precio;

        private string tipo;

        public CAuto(double precio, string tipo)
        {
            this.precio = precio;
            this.tipo = tipo;
        }

        public double CalcularPrecio()
        {
            return precio;
        }

        public string DecirPropiedades()
        {
            return "El tipo del auto es " + tipo;
        }


    }
}
