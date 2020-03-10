using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q15Estado
{
    class CCaldera : IEstado
    {
        private IEstado estado;
        private IEstado alarma;
        private IEstado reposo;
        private IEstado calentando;
        private int temperatura;
        private int combustible;



        public CCaldera()
        {
            this.temperatura = 20;
            this.combustible = 60;
            this.alarma = new CEstadoAlarma(this);
            this.reposo = new CReposo(this);
            this.calentando = new CEstadoCalentando(this);

            this.estado = calentando;
        }

        public int Temperatura { get => temperatura; set => temperatura = value; }
        public int Combustible { get => combustible; set => combustible = value; }
        internal IEstado Estado { get => estado; }
        internal IEstado Alarma { get => alarma; }
        internal IEstado Reposo { get => reposo; }
        internal IEstado Calentando { get => calentando; }


        public void ColocarEstado(IEstado estado)
        {
            this.estado = estado;
        }

        public void Trabajar()
        {
            estado.Trabajar();
        }

        public void CortarFuego()
        {
            estado.CortarFuego();
        
        }

        public void PonerCombustible()
        {
            estado.PonerCombustible();
        }

        public void ForzarFuego()
        {
            estado.ForzarFuego();
        }

        public override string ToString()
        {
            return estado.ToString();
        }

    }
}
