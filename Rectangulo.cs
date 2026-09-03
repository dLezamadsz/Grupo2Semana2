using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebatanaka
{
    internal class Rectangulo : Figura
    {
        private float baseRectangulo;
        private float alturaRectangulo;
        public override float CalcularArea()
        {
            return baseRectangulo * alturaRectangulo;
        }
    }
}
