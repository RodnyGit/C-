using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q14Templates
{
    class CAlgoritmo
    {
        public double Metodotemplate(IPrimitiva tipo, int cantidad)
        {
            double total = 0;
            total += CrearJuguete(cantidad);
            total += tipo.Decorar(cantidad);
            Calidad();
            total += tipo.Empacar(cantidad);
            return total;
        }

        private double CrearJuguete(int cantidad)
        {
            Console.WriteLine("Estamos creando {0} creando juguetes", cantidad);
            return cantidad * 16.5;
        }

        private void Calidad()
        {
            Console.WriteLine("Pasa Control de Calidad");
        }
    }
}
