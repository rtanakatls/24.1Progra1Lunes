using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra1
{
    internal class Square : Rectangle
    {
        public Square(float side) : base(side, side)
        {
            type = "Square";
        }
    }
}
