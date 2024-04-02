using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra1
{
    internal abstract class Shape
    {
        protected string type;

        public string Type
        {
            get { return type; }
        }

        public abstract float GetArea();



        
    }
}
