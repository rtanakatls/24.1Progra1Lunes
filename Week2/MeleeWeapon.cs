using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra1.Week2
{
    internal class MeleeWeapon : Weapon
    {
        private int durability;

        public MeleeWeapon(int damage, int durability) : base(damage)
        {
            this.durability = durability;
        }


    }
}
