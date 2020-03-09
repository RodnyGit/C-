using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q15Estado
{
    class CEstadoCalentando : IEstado
    {
        private CCaldera miCaldera;

        public CEstadoCalentando(CCaldera miCaldera)
        {
            this.miCaldera = miCaldera;
        }

        public CCaldera MiCaldera { get => miCaldera; set => miCaldera = value; }



        public void CortarFuego()
        {
            Console.WriteLine("Apagando Fuego");
            miCaldera.ColocarEstado(miCaldera.Reposo);
        }

        public void ForzarFuego()
        {
            Console.WriteLine("Prendiendo Fuego");
            miCaldera.ColocarEstado(miCaldera.Calentando);
        }

        public void PonerCombustible()
        {
            Console.WriteLine("No se puede poner combustible con la carder prendida");
        }

        public void Trabajar()
        {
            if (miCaldera.Combustible>0)
            {
                Console.WriteLine("Estamos calentando");
                miCaldera.Combustible -= 3;
                miCaldera.Temperatura += 10;

                if (miCaldera.Temperatura>100)
                {
                    miCaldera.ColocarEstado(miCaldera.Alarma);
                }
                else if (miCaldera.Temperatura>80)
                {
                    miCaldera.ColocarEstado(miCaldera.Reposo);
                }
                if (miCaldera.Combustible<=1)
                {
                    miCaldera.ColocarEstado(miCaldera.Reposo);
                }

            }
        }
    }
}
