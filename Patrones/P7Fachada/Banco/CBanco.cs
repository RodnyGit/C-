using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubSistemas
{
    class CBanco
    {
        private string nombre;
        private List<CCuenta> cuentas;

        public CBanco(string nombre)
        {
            this.nombre = nombre;
            this.cuentas = new List<CCuenta>();
        }

        public string Nombre { get => nombre; }

        public string AddCuenta(CCuenta newCuenta)
        {
            cuentas.Add(newCuenta);
            return "Correcto";
        }
        public bool ExisteCuenta(int numero)
        {
            foreach (CCuenta item in cuentas)
                if (item.Id == numero)
                    return true;
            return false;
        }
        public CCuenta ObtenerCuenta(int id)
        {
            return cuentas[id];
        }
        public override string ToString()
        {
            return "Banco "+nombre;
        }



    }
}
