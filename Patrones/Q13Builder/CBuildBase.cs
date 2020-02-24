using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q13Builder
{
    class CBuildBase : IBuilder
    {
        CProducto producto = new CProducto();
        public void ConstruyeCarroceria()
        {
            producto.ColocarCarroceria(new CCarroceriaBase());
        }

        public void ConstruyeLlanta()
        {
            producto.ColocarLlantas(new CLlantaSimple());
        }

        public void ConstruyeMotor()
        {
            producto.ColocarMotor(new CMotorBase());
        }

        public CProducto EnsamblarProducto()
        {
            return producto;
        }
    }
}
