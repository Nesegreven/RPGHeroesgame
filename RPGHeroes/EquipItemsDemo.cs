using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//The purpose of this demo was to make a console output for the varioes actions, as i found that the unit test was somewhat more difficult wrap my head around to work with
//when prototyping new code and checking if an approach would yield.
//the code autoruns on compilation.
//a list of items is generated using ItemGenerator 
//then EquipItemsDemo loop through all the availble equipment and displays output if item is equipped, replaced, cant equp due to level or material
//it also displays the hero at startingpoint and final state with equipment and stats after level up
namespace RPGHeroes
{
    public class EquipItemsDemo
    {
        public static void Run()
        {
            // Create a hero
            Hero hero = new Warrior("Aragon");

            // Generate items
            List<Item> items = ItemGenerator.GenerateItems();

            // List all available items
            ListAvailableItems(items);

            Console.WriteLine("Initial hero state:");
            Console.WriteLine(hero.Display());

            // Equip items loop throgh the generated lsit of items an print errors or if item was equipped
            foreach (var item in items)
            {
                try
                {
                    if (item is Weapon weapon)
                    {
                        hero.Equip(weapon);
                    }
                    else if (item is Armor armor)
                    {
                        hero.Equip(armor);
                    }
                    Console.WriteLine($"Equipped {item.Name}");
                }
                catch (InvalidWeaponException e)
                {
                    Console.WriteLine($"Couldn't equip {item.Name}: {e.Message}");
                }
                catch (InvalidArmorException e)
                {
                    Console.WriteLine($"Couldn't equip {item.Name}: {e.Message}");
                }
            }

            Console.WriteLine("\nFully equipped hero state:");
            Console.WriteLine(hero.Display());
            hero.LevelUp();
            Console.WriteLine("\nLevel up the character and display final hero state:");
            Console.WriteLine(hero.Display());

        }
        private static void ListAvailableItems(List<Item> items) // Displays a list of all available items and theri attributes.
        {
            Console.WriteLine("Available Equipment:");
            Console.WriteLine("Weapons:");
            foreach (var weapon in items.OfType<Weapon>())
            {
                Console.WriteLine($"- {weapon.Name} (Type: {weapon.WeaponType}, Required Level: {weapon.RequiredLevel}, Damage: {weapon.WeaponDamage})");
            }

            Console.WriteLine("\nArmor:");
            foreach (var armor in items.OfType<Armor>())
            {
                Console.WriteLine($"- {armor.Name} (Type: {armor.ArmorType}, Slot: {armor.Slot}, Required Level: {armor.RequiredLevel})");
                Console.WriteLine($"  Attributes: Str {armor.ArmorAttribute.Strength}, Dex {armor.ArmorAttribute.Dexterity}, Int {armor.ArmorAttribute.Intelligence}");
            }
            Console.WriteLine();
        }
    }
}
