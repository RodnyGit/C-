using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q10Fabrica
{
    class CFabrica
    {
        static public IAutomovil CrearVeiculo(string tipo)
        {
            if (tipo == "bici")
            {
                CBicicleta bici = new CBicicleta();
                return bici;
            }
            if (tipo == "auto")
            {
                CAutomovil automovil = new CAutomovil();
                return automovil;
            }
            return null;
        }
    }
}
