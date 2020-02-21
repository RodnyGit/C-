using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P9Prototipo
{
    class CAdminProtos
    {
        private IDictionary<string, IPrototipo> protoContainer = new Dictionary<string, IPrototipo>();

        public CAdminProtos()
        {
            CCalcularPalabra calcularPalabra = new CCalcularPalabra(279819854);
            CRamdomWord ramdomWord = new CRamdomWord("aeu");

            protoContainer.Add("calcularPalabra", calcularPalabra);
            protoContainer.Add("ramdomWord", ramdomWord);
        }

        public IDictionary<string, IPrototipo> ProtoContainer { get => protoContainer; }

        public void AdicionarPrototipo(string nombre, IPrototipo objeto)
        {
            protoContainer.Add(nombre, objeto);
        }
        public List<string> nombresProtos()
        {
            List<string> nombres = new List<string>();
            foreach (string item in protoContainer.Keys)
            {
                nombres.Add(item);
            }
            return nombres;
        }
    }
}
