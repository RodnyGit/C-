using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q13Builder
{
    class CDirector
    {
        public void Construye(IBuilder constructor)
        {
            constructor.ConstruyeMotor();
            constructor.ConstruyeCarroceria();
            constructor.ConstruyeLlanta();
        }
    }
}
