using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo2Semana1
{
    internal class Cuadrado : Rectangulo 
    {
        public float lado;
        public Cuadrado(float lado)
        {
            this.lado = lado;
        }
        public override float GetArea()
        {
            return lado * lado;
        }
    }
}
