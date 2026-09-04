using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo2Semana2
{
    internal class Triangulo : Figura
    {
        protected float baseT;
        protected float altura;
        protected float area;

        public Triangulo(float baseT, float altura)
        {
            this.baseT = baseT;
            this.altura = altura;
        }

        public override float GetArea()
        {
            return area = (baseT * altura) / 2;
        }
    }
}