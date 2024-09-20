using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes
{
    public class Rogue : Hero
    {
        public Rogue(string name) : base(name) // Set initial attributes for a Rogue favoring dexterity
        {
            LevelAttributes = new HeroAttribute(2, 6, 1);
            ValidWeaponTypes = new List<WeaponType> { WeaponType.Dagger, WeaponType.Sword };// Define valid weapon types for a Rogue
            ValidArmorTypes = new List<ArmorType> { ArmorType.Leather, ArmorType.Mail };// Define valid armor types for a Rogue
        }

        public override void LevelUp()// Increases the Rogue's level increasing attributes favoring dexterity
        {
            Level++;
            LevelAttributes = new HeroAttribute(
                LevelAttributes.Strength + 1,
                LevelAttributes.Dexterity + 4,
                LevelAttributes.Intelligence + 1
            );
        }

        protected override int DamagingAttribute()// Determines the attribute that affects the Rogue's damage calculation
        {
            return TotalAttributes().Dexterity;
        }

       
    }
}
