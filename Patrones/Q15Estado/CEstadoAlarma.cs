using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q15Estado
{
    class CEstadoAlarma : IEstado
    {


        private CCaldera miCaldera;

        public CEstadoAlarma(CCaldera miCaldera)
        {
            this.miCaldera = miCaldera;
        }

        public CCaldera MiCaldera { get => miCaldera; set => miCaldera = value; }



        public void CortarFuego()
        {
            Console.WriteLine("La caldera esta apagada...");
        }

        public void ForzarFuego()
        {
            if (miCaldera.Temperatura>3)
            {
                Console.WriteLine("Riesgo de explosion...");
                miCaldera.Combustible -= 3;
                miCaldera.Temperatura += 10;
            }
            else
            {
                Console.WriteLine("No hay combustible...");
            }
        }

        public void PonerCombustible()
        {
            Console.WriteLine("No se puede poner combustible con altas temperaturas...");
        }

        public void Trabajar()
        {
            Console.WriteLine("ALARMA...! ALTAS TEMPERATURAS..!");
            miCaldera.Temperatura -= 5;

            if (miCaldera.Temperatura < 90 && miCaldera.Combustible > 3)
            {
                miCaldera.ColocarEstado(miCaldera.Reposo);
            }
        }
        public override string ToString()
        {
            return $"Alarma... Temp: {miCaldera.Temperatura}, Comb: {miCaldera.Combustible}";
        }
    }
}
