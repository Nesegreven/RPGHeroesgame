using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes
{
    public class Warrior : Hero
    {
        public Warrior(string name) : base(name) // Set initial attributes for a Warrior favoring Strength
        {
            LevelAttributes = new HeroAttribute(5, 2, 1);
            ValidWeaponTypes = new List<WeaponType> { WeaponType.Axe, WeaponType.Hammer, WeaponType.Sword };
            ValidArmorTypes = new List<ArmorType> { ArmorType.Mail, ArmorType.Plate };
        }

        public override void LevelUp()// Increases the Warrior level increasing attributes favoring Strength
        {
            Level++;
            LevelAttributes = new HeroAttribute(
                LevelAttributes.Strength + 3,
                LevelAttributes.Dexterity + 2,
                LevelAttributes.Intelligence + 1
            );
        }

        protected override int DamagingAttribute()// Determines the attribute that affects the Warrior damage calculation
        {
            return TotalAttributes().Strength;
        }

    }
}
