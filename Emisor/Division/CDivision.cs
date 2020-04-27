using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Division
{
    public class CDivision
    {
        #region Equivalencia
        public delegate void miEvento(object sender, ZeroDivisionEventArgs e);//nueva firma de delegado
        public event miEvento ZeroDivisionEventHandler; //declaracion de delegado con la firma declarada

        #endregion
        //public event Action<object, ZeroDivisionEventArgs> ZeroDivisionEventHandler;

        public double Division(double a, double b)
        {
            if (b == 0)
            {
                if (ZeroDivisionEventHandler != null)
                {
                    ZeroDivisionEventHandler(this, new ZeroDivisionEventArgs(a, b));
                }
                return 0;
            }
            return a / b;
        }
    }
    public class ZeroDivisionEventArgs : EventArgs
    {
        private double a;
        private double b;

        public ZeroDivisionEventArgs(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public double A { get => a; set => a = value; }
        public double B { get => b; set => b = value; }
    }
}
