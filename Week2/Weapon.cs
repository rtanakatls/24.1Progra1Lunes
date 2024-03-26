using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra1.Week2
{
    internal class Weapon
    {
        protected int damage;
        public Weapon(int damage)
        {
            this.damage = damage;
        }

        public virtual int GetDamage()
        {
            return damage;
        }
    }
}
