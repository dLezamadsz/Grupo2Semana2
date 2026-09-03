using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo2Semana1
{
    internal class Circulo : Shape
    {
        public float r;

        public Circulo(float r)
        {
            this.r = r;
        }

        public override float GetArea()
        {
            return 3.14f * r * r;
        }
    }
}
