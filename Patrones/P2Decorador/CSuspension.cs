using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2Decorador
{
    class CSuspension : IDecorador
    {
        private double precio;

        private string tipo;

        private IDecorador decorable;

        public CSuspension(double precio, string tipo, IDecorador decorable)
        {
            this.precio = precio;
            this.tipo = tipo;
            this.decorable = decorable;
        }

        public double CalcularPrecio()
        {
            return precio + decorable.CalcularPrecio();
        }

        public string DecirPropiedades()
        {
            return decorable.DecirPropiedades() + " El tipo de suspension es " + tipo;
        }
    }
}
