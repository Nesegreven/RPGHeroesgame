using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes
{
    public class Ranger : Hero
    {
        public Ranger(string name) : base(name)// Set initial attributes for a Rogue favoring dexterity
        {
            LevelAttributes = new HeroAttribute(1, 7, 1);
            ValidWeaponTypes = new List<WeaponType> { WeaponType.Bow };
            ValidArmorTypes = new List<ArmorType> { ArmorType.Leather, ArmorType.Mail };
        }

        public override void LevelUp()// Increases the Ranger's level increasing attributes favoring dexterity
        {
            Level++;
            LevelAttributes = new HeroAttribute(
                LevelAttributes.Strength + 1,
                LevelAttributes.Dexterity + 5,
                LevelAttributes.Intelligence + 1
            );
        }

        protected override int DamagingAttribute()// Determines the attribute that affects the Rangers damage calculation
        {
            return TotalAttributes().Dexterity;
        }

       
    }
}
