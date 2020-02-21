using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q10Fabrica
{
    class CBicicleta : IAutomovil
    {
        public string Arrancar()
        {
            return "Las bicicletas no arrancan";
        }

        public string Doblar()
        {
            return "Usando el timon para doblar";
        }

        public string Frenar()
        {
            return "Apretando frenos";
        }

        public string Pitar()
        {
            return "Tocando timbre";
        }
    }
}
