using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra1
{
    internal class Circle : Shape
    {
        private float r;

        public Circle(float r)
        {
            this.type = "Círculo";
            this.r = r;
        }

        public override float GetArea()
        {
            return 3.14f * r * r;
        }
    }
}
