using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace P9Prototipo
{
    class CAdminProtos
    {
        private IDictionary<string, IPrototipo> protoContainer = new Dictionary<string, IPrototipo>();
        CCalcularPalabra calcularPalabra;
        CRamdomWord randomWord;        

        public CAdminProtos()
        {
            calcularPalabra = new CCalcularPalabra(279819854);
            randomWord = new CRamdomWord("aeua");
            protoContainer.Add("calcularPalabra", calcularPalabra);
            protoContainer.Add("ramdomWord", randomWord);
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
