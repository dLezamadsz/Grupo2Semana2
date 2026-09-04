using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo2Semana2
{
    internal class Rectangulo : Figura
    {
        public float baseRectangulo;
        public float alturaRectangulo;
        public override float CalcularArea()
        {
            return baseRectangulo * alturaRectangulo;
        }
    }
}
