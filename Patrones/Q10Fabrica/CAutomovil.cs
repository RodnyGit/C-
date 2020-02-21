using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q10Fabrica
{
    class CAutomovil : IAutomovil
    {
        public string Arrancar()
        {
            return "Arrancando auntomovil";
        }

        public string Doblar()
        {
            return "Usando el timon para doblar";
        }

        public string Frenar()
        {
            return "Frenando el carro";
        }

        public string Pitar()
        {
            return "Usando el claxon para pitar";
        }
    }
}
