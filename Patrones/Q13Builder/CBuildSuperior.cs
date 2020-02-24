using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q13Builder
{
    class CBuildSuperior : IBuilder
    {
        CProducto producto = new CProducto();
        public void ConstruyeCarroceria()
        {
            producto.ColocarCarroceria(new CCarroceriaEspecial());
        }

        public void ConstruyeLlanta()
        {
            producto.ColocarLlantas(new CLlantaModerna());
        }

        public void ConstruyeMotor()
        {
            producto.ColocarMotor(new CMotorGrande());
        }

        public CProducto EnsamblarProducto()
        {
            return producto;
        }
    }
}
