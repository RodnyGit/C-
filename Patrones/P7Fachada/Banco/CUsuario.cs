using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubSistemas
{
    class CUsuario
    {
        private string nombre;
        private int id;
        private List<int> cuentas;

        public CUsuario(string nombre, int id)
        {
            this.nombre = nombre;
            this.id = id;
            this.cuentas = new List<int>();
        }
        public string Nombre { get => nombre; }
        public int Id { get => id; }
        public void AddCuenta(int cuenta)
        {
            cuentas.Add(cuenta);
        }
        public override string ToString()
        {
            return "Usuario " + nombre + " con identificador " + id;
        }
    }
}
