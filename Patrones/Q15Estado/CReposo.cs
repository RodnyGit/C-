using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q15Estado
{
    class CReposo : IEstado
    {
        private CCaldera miCaldera;

        public CReposo(CCaldera miCaldera)
        {
            this.miCaldera = miCaldera;
        }

        public CCaldera MiCaldera { get => miCaldera; set => miCaldera = value; }

        public void CortarFuego()
        {
            Console.WriteLine("El fuego esta apagado");
        }

        public void ForzarFuego()
        {
            Console.WriteLine("Encendiendo la caldera de forma manual...");
            miCaldera.Combustible -= 3;
            miCaldera.Temperatura += 10;
            if (miCaldera.Temperatura > 100)
            {
                miCaldera.ColocarEstado(miCaldera.Alarma);
            }
        }

        public void PonerCombustible()
        {
            Console.WriteLine("Poniendo combustible...");
            miCaldera.Combustible += 28;
        }

        public void Trabajar()
        {
            if (miCaldera.Temperatura>20)
            {
                miCaldera.Temperatura -= 5;
            }
            if (miCaldera.Temperatura < 60 && miCaldera.Combustible >= 3)
                miCaldera.ColocarEstado(miCaldera.Calentando);
        }
        public override string ToString()
        {
            return $"Reposo... Temp: {miCaldera.Temperatura}, Comb: {miCaldera.Combustible}";
        }
    }
}
