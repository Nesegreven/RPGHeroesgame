using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes
{
    public abstract class Hero // Abstract base class for all hero types in the game
    {                          
        //Properties

        public string Name { get; private set; }
        public int Level { get; protected set; }
        public HeroAttribute LevelAttributes { get; protected set; }
        public Dictionary<Slot, Item> Equipment { get; private set; }
        public List<WeaponType> ValidWeaponTypes { get; protected set; }
        public List<ArmorType> ValidArmorTypes { get; protected set; }
        


        protected Hero(string name) // Constructor for the Hero class.
        {
            Name = name;
            Level = 1;
            Equipment = new Dictionary<Slot, Item>
            {
                { Slot.Weapon, null },
                { Slot.Head, null },
                { Slot.Body, null },
                { Slot.Legs, null }
            };
            ValidWeaponTypes = new List<WeaponType>();
            ValidArmorTypes = new List<ArmorType>();
        }

        public abstract void LevelUp(); // Abstract method to be implemented by subclasses for leveling up the hero.

        public void Equip(Weapon weapon) // Equips a weapon to the hero if it meets the requirements.
        {
            if (weapon == null)
                throw new ArgumentNullException(nameof(weapon), "Cannot equip null weapon.");

            if (Level < weapon.RequiredLevel)
                throw new InvalidWeaponException($"Hero level too low to equip {weapon.Name}. Required level: {weapon.RequiredLevel}");

            if (!ValidWeaponTypes.Contains(weapon.WeaponType))
                throw new InvalidWeaponException($"Hero cannot equip {weapon.WeaponType} weapon.");

            if (Equipment[Slot.Weapon] != null)
            {
                Console.WriteLine($"Replacing {Equipment[Slot.Weapon].Name} with {weapon.Name} in Weapon slot.");
            }

            Equipment[Slot.Weapon] = weapon;
            Console.WriteLine($"Equipped {weapon.Name} in Weapon slot.");
        }

        public void Equip(Armor armor) // Equips an armor piece to the hero if it meets the requirements
        {
            if (armor == null)
                throw new ArgumentNullException(nameof(armor), "Cannot equip null armor.");

            if (Level < armor.RequiredLevel)
                throw new InvalidArmorException($"Hero level too low to equip {armor.Name}. Required level: {armor.RequiredLevel}");

            if (!ValidArmorTypes.Contains(armor.ArmorType))
                throw new InvalidArmorException($"Hero cannot equip {armor.ArmorType} armor.");

            if (Equipment[armor.Slot] != null)
            {
                Console.WriteLine($"Replacing {Equipment[armor.Slot].Name} with {armor.Name} in {armor.Slot} slot.");
            }

            Equipment[armor.Slot] = armor;
            Console.WriteLine($"Equipped {armor.Name} in {armor.Slot} slot.");
        }

            public HeroAttribute TotalAttributes() // Calculates the total attributes of the hero, including equipment bonuses.
        {
            var total = new HeroAttribute(LevelAttributes.Strength, LevelAttributes.Dexterity, LevelAttributes.Intelligence);
            foreach (var item in Equipment.Values)
            {
                if (item is Armor armor)
                {
                    total += armor.ArmorAttribute;
                }
            }
            return total;
        }

        public double Damage() // Calculates the hero's damage output using the damagemodifer for each class.
        {
            return Math.Round(BaseDamage() * (1 + DamagingAttribute() / 100.0), 2);
        }

        protected double BaseDamage() // Calculates the base damage of the hero based on the equipped weapon
        {
            var weapon = Equipment[Slot.Weapon] as Weapon;
            return weapon?.WeaponDamage ?? 1;
        }

        protected double DamageAttribute(HeroAttribute heroclassdamageattribute)// Helper method to determine the damaging attribute based on hero class.
        {
            return heroclassdamageattribute switch
            {
                var a when this is Mage => a.Intelligence,
                var a when this is Ranger => a.Dexterity,
                var a when this is Rogue => a.Dexterity,
                var a when this is Warrior => a.Strength,
                _ => throw new InvalidOperationException("Unknown hero type")
            };
        }
        protected abstract int DamagingAttribute(); // Abstract method to be implemented by subclasses to determine the hero's damaging attribute.

        public virtual string Display() // Generates a string representation of the hero's current state, attributes and, equipment is out of scope of the task but i found it to be worth adding for my own sake.
        {
            var attributes = TotalAttributes();
            StringBuilder displayhero = new StringBuilder();

            displayhero.AppendLine($"Name: {Name}");
            displayhero.AppendLine($"Class: {GetType().Name}");
            displayhero.AppendLine($"Level: {Level}");
            displayhero.AppendLine($"Strength: {attributes.Strength}");
            displayhero.AppendLine($"Dexterity: {attributes.Dexterity}");
            displayhero.AppendLine($"Intelligence: {attributes.Intelligence}");
            displayhero.AppendLine($"Damage: {Damage()}");

            displayhero.AppendLine("Equipment:");
            foreach (var keyvaluepair in Equipment)
            {
                string slotName = keyvaluepair.Key.ToString();
                if (keyvaluepair.Value != null)
                {
                    if (keyvaluepair.Value is Weapon weapon)
                    {
                        displayhero.AppendLine($"  {slotName}: {weapon.Name} (Type: {weapon.WeaponType}, Damage: {weapon.WeaponDamage})");
                    }
                    else if (keyvaluepair.Value is Armor armor)
                    {
                        displayhero.AppendLine($"  {slotName}: {armor.Name} (Type: {armor.ArmorType}, Attributes: Str {armor.ArmorAttribute.Strength}, Dex {armor.ArmorAttribute.Dexterity}, Int {armor.ArmorAttribute.Intelligence})");
                    }
                }
                else
                {
                    displayhero.AppendLine($"  {slotName}: Empty");
                }
            }

            return displayhero.ToString();
        }
    }
}

