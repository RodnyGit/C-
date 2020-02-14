using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubSistemas
{
    class CCuenta
    {
        private int id;
        private CUsuario usuario;
        private double monto;
        private string banco;
        private int ping = 123;

        public CCuenta(int id, CUsuario usuario, string banco)
        {
            this.id = id;
            this.usuario = usuario;
            this.monto = 0;
            this.banco = banco;
        }

        public int Id { get => id; }
        public double Monto { get => monto; }
        public string Banco { get => banco; }
        public string CambiarPing(int pingViejo, int pingNuevo)
        {
            if (pingViejo == this.ping)
            {
                this.ping = pingNuevo;
                return "se ha cambiado el ping de forma correcta";
            }
            return "ping incorrecto";
        }
        public bool Verificacion(int clave)
        {
            if (clave == this.ping)
            {
                return true;
            }
            return false;
        }
        public bool Extracto(int confirmacion, double cantidad)
        {
            if ((confirmacion == ping) && (cantidad < monto))
            {
                monto -= cantidad;
                return true;
            }
            return false;
        }
        public string Deposito(double cantidad)
        {
            monto += cantidad;
            return "se han extraido " + cantidad + " pesos de la cuenta " + id + " del usuario " + usuario.Nombre;
        }
    }
}
