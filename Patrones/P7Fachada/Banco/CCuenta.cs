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
        private double monto;
        private int ping = 123;
        private CUsuario usuario;
        private CBanco banco;

        public CCuenta(int id, CUsuario usuario, CBanco banco)
        {
            this.id = id;
            this.usuario = usuario;
            this.monto = 0;
            this.banco = banco;
            usuario.AddCuenta(id);
        }

        public int Id { get => id; }
        public double Monto { get => monto; }
        public CBanco Banco { get => banco; }
        public CUsuario Usuario { get => usuario; }

        public string CambiarPing(int pingViejo, int pingNuevo)
        {
            if (this.ping == pingViejo)
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
        public override string ToString()
        {
            return "idCuenta "+id+" monto "+monto+" Banco "+banco.Nombre+" Usuario "+usuario.Nombre;
        }
    }
}
