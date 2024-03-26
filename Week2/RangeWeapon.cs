using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra1.Week2
{
    internal class RangeWeapon : Weapon
    {
        private int projectileDamage;

        public RangeWeapon(int damage, int projectileDamage) : base(damage)
        {
            this.projectileDamage = projectileDamage;
        }

        public override int GetDamage()
        {
            return damage + projectileDamage;
        }
    }
}
