using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q13Builder
{
    class CProducto
    {
        ICarroceria carroceria;
        ILlantas llantas;
        IMotor motor;

        public void ColocarMotor(IMotor motor)
        {
            this.motor = motor;
            Console.WriteLine("Se a puesto {0}", motor.TipoMotor());
        }
        public void ColocarLlantas(ILlantas llantas)
        {
            this.llantas = llantas;
            Console.WriteLine("Se han puesto {0}", llantas.DetallesLanta());
        }
        public void ColocarCarroceria(ICarroceria carroceria)
        {
            this.carroceria = carroceria;
            Console.WriteLine("Se a puesto {0}", carroceria.Caraceristicas());
        }

        public void Detalles()
        {
            Console.WriteLine("Su vehiculo tiene  {0}, con unas {1}, y {2}", motor.TipoMotor(), llantas.DetallesLanta(), carroceria.Caraceristicas());
        }
    }
}
