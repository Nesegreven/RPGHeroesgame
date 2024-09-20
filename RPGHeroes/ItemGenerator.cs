using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes
{
    public class ItemGenerator // Generates a list of predefined weapons and armor items
    {
        public static List<Item> GenerateItems()
        {
            List<Item> items = new List<Item>
        {
            // Weapons
            new Weapon("Wooden Sword", 1, WeaponType.Sword),
            new Weapon("Steel Axe", 1, WeaponType.Axe),
            new Weapon("Longbow", 1, WeaponType.Bow),
            new Weapon("Magic Staff", 4, WeaponType.Staff),

            // Armor - Head
            new Armor("Leather Cap", 1, Slot.Head, ArmorType.Leather),
            new Armor("Iron Helmet", 1, Slot.Head, ArmorType.Mail),
            new Armor("Mage Hat", 1, Slot.Head, ArmorType.Cloth),

            // Armor - Body
            new Armor("Cloth Robe", 1, Slot.Body, ArmorType.Cloth),
            new Armor("Chainmail", 1, Slot.Body, ArmorType.Mail),
            new Armor("Plate Armor", 1, Slot.Body, ArmorType.Plate),
            new Armor("Mithril Plate Armor", 2, Slot.Body, ArmorType.Plate),

            // Armor - Legs
            new Armor("Leather Boots", 1, Slot.Legs, ArmorType.Leather),
            new Armor("Steel Greaves", 1, Slot.Legs, ArmorType.Plate),
            new Armor("Enchanted Sandals", 1, Slot.Legs, ArmorType.Cloth)
        };

            return items;
        }
    }
}
