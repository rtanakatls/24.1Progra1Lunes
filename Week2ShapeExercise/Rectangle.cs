using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra1
{
    internal class Rectangle : Shape
    {
        protected float width;
        protected float height;

        public Rectangle(float width, float height)
        {
            this.width = width;
            this.height = height;
            type = "Rectangle";
        }

        public override float GetArea()
        {
            return width * height;
        }

    }
}
