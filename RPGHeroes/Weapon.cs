using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes
{
    
    public class Weapon : Item
    {
        public WeaponType WeaponType { get; private set; }
        public int WeaponDamage { get; private set; }

        public Weapon(string name, int requiredLevel, WeaponType weaponType)
            : base(name, requiredLevel, Slot.Weapon)
        {
            WeaponType = weaponType;
            WeaponDamage = GetBaseDamage(weaponType);
        }

        private int GetBaseDamage(WeaponType type)// right now damage is not unique to the weapon but rather based on weapon type.
        {                                         // Determines the base damage for a given weapon type
            return type switch
            {
                WeaponType.Axe => 7,
                WeaponType.Bow => 12,
                WeaponType.Dagger => 4,
                WeaponType.Hammer => 10,
                WeaponType.Staff => 6,
                WeaponType.Sword => 5,
                WeaponType.Wand => 2,
                _ => throw new ArgumentException("Invalid weapon type")
            };
        }
    }
}
