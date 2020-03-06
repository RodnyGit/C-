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
        public event Action<object, ObjetoEventArgs> objetoNuevo;


        public CAdminProtos()
        {
            Task tarea = Task.Run(() =>
             {
                 calcularPalabra = new CCalcularPalabra(279819854);
                 if (objetoNuevo != null)
                 {
                     objetoNuevo(this, new ObjetoEventArgs(calcularPalabra));
                 }
                 randomWord = new CRamdomWord("aeua");
                 if (objetoNuevo != null)
                 {
                     objetoNuevo(this, new ObjetoEventArgs(randomWord));
                 }
                 protoContainer.Add("calcularPalabra", calcularPalabra);
                 protoContainer.Add("ramdomWord", randomWord);

             });
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
    class ObjetoEventArgs : EventArgs
    {
        private object objeto;

        public ObjetoEventArgs(object objeto)
        {
            this.objeto = objeto;
        }

        public object Objeto { get => objeto; set => objeto = value; }
    }
}
