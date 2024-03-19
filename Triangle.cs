using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra1
{
    internal class Triangle : Shape
    {
        private float b;
        private float h;

        public Triangle(float b, float h)
        {
            this.type = "Triángulo";
            this.b = b;
            this.h = h;
        }

        public override float GetArea()
        {
            return b * h / 2;
        }

    }
}
