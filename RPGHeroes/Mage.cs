using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes
{
    public class Mage : Hero
    {
        public Mage(string name) : base(name)// Set initial attributes for a Mage favoring Intelligence
        {
            LevelAttributes = new HeroAttribute(1, 1, 8);
            ValidWeaponTypes = new List<WeaponType> { WeaponType.Staff, WeaponType.Wand };
            ValidArmorTypes = new List<ArmorType> { ArmorType.Cloth };
        }

        public override void LevelUp()// Increases the Mage level increasing attributes favoring Intelligence
        {
            Level++;
            LevelAttributes = new HeroAttribute(
                LevelAttributes.Strength + 1,
                LevelAttributes.Dexterity + 1,
                LevelAttributes.Intelligence + 5
            );
        }

        protected override int DamagingAttribute() // Determines the attribute that affects the Mage damage calculation
        {
            return TotalAttributes().Intelligence;
        }

    }
}
