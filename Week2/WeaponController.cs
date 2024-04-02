using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra1.Week2
{
    internal class WeaponController
    {
    
        public void Execute()
        {


            List<Weapon> weapons = new List<Weapon>();
            RangeWeapon rangeWeapon= new RangeWeapon(10, 2);
            weapons.Add(rangeWeapon);
            weapons.Add(new MeleeWeapon(10, 5));

            List<IShooter> shooters = new List<IShooter>();

            shooters.Add(rangeWeapon);

            foreach(Weapon weapon in weapons)
            {
                Console.WriteLine(weapon.GetDamage());
            }
            
        }
    }
}
