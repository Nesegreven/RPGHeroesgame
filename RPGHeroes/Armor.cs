using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes
{
    
    public class Armor : Item
    {
        public ArmorType ArmorType { get; private set; } // Gets the type of the armor.
        public HeroAttribute ArmorAttribute { get; private set; }// Gets the attribute bonuses provided by the armor.

        public Armor(string name, int requiredLevel, Slot slot, ArmorType armorType)//new instance of the Armor class
            : base(name, requiredLevel, slot)
        {
            ArmorType = armorType;
            ArmorAttribute = GetBaseAttributes(armorType);
        }

        private HeroAttribute GetBaseAttributes(ArmorType type)//right now armor stats is not unique but based on type
        {
                                                                //Determines the base attribute bonuses for a given armor type
            return type switch
            {
                ArmorType.Cloth => new HeroAttribute(1, 1, 5),
                ArmorType.Leather => new HeroAttribute(2, 4, 1),
                ArmorType.Mail => new HeroAttribute(3, 2, 1),
                ArmorType.Plate => new HeroAttribute(5, 1, 1),
                _ => throw new ArgumentException("Invalid armor type")
            };
        }
    }
}
