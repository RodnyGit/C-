using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q15Estado
{
    class CCaldera
    {
        private IEstado estado;
        private IEstado alarma;
        private IEstado reposo;
        private IEstado calentando;
        private int temperatura;
        private int combustible;



        public CCaldera(int temperatura, int combustible, IEstado estado)
        {
            this.temperatura = temperatura;
            this.combustible = combustible;
            this.estado = estado;
            this.alarma = estado;
            this.reposo = estado;
            this.calentando = estado;
        }

        public void ColocarEstado(IEstado estado)
        {
            this.estado = estado;
        }

        public int Temperatura { get => temperatura; set => temperatura = value; }
        public int Combustible { get => combustible; set => combustible = value; }
        internal IEstado Estado { get => estado; }
        internal IEstado Alarma { get => alarma; }
        internal IEstado Reposo { get => reposo; }
        internal IEstado Calentando { get => calentando; }
    }
}
