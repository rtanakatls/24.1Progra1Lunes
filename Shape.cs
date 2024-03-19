using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra1
{
    internal class Shape
    {
        protected string type;

        public string Type
        {
            get { return type; }
        }

        public virtual float GetArea()
        {
            return 0;
        }

        
    }
}
