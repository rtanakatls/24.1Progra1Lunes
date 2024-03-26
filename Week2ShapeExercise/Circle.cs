using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra1
{
    internal class Circle : Shape
    {
        protected float radius;

        public Circle(float radius)
        {
            this.radius = radius;
            type = "Circle";
        }

        public override float GetArea()
        {
            return 3.14f * radius * radius;
        }
    }
}
