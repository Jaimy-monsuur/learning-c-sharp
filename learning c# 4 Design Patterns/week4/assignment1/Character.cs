using System;
using System.Collections.Generic;
using System.Text;

namespace assignment1
{
    public abstract class Character
    {
        public IWeaponBehaviour Weapon { get; set; }
        public Character()
        {
            
        }

        public void Fight()
        {
            Weapon.UseWeapon();
        }
    }
}
