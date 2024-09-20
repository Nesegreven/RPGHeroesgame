using RPGHeroes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroesTest
{
    public class DisplayTests
    {
        
        [Fact]
        public void Mage_Display_ShouldReturnCorrectString()
        {
            // Arrange
            Hero mage = new Mage("TestMage");
            Weapon weapon = new Weapon("TestStaff", 1, WeaponType.Staff);
            Armor armor = new Armor("TestCloth", 1, Slot.Body, ArmorType.Cloth);
            mage.Equip(weapon);
            mage.Equip(armor);

            // Act
            string display = mage.Display();

            // Assert
            Assert.Contains("Name: TestMage", display);
            Assert.Contains("Class: Mage", display);
            Assert.Contains("Level: 1", display);
            Assert.Contains("Strength: 2", display);  // 1 (base) + 1 (cloth armor)
            Assert.Contains("Dexterity: 2", display);  // 1 (base) + 1 (cloth armor)
            Assert.Contains("Intelligence: 13", display);  // 8 (base) + 5 (cloth armor)
            Assert.Contains("Damage: 6,78", display);  // 6 (staff) * (1 + 13/100)

            // Additional assertions for equipment
            Assert.Contains("Weapon: TestStaff", display);
            Assert.Contains("Body: TestCloth", display);
        }
        [Fact]
        public void Ranger_Display_ShouldReturnCorrectString()
        {
            // Arrange
            Hero ranger = new Ranger("TestRanger");
            Weapon weapon = new Weapon("TestBow", 1, WeaponType.Bow);
            Armor armor = new Armor("TestLeather", 1, Slot.Body, ArmorType.Leather);
            ranger.Equip(weapon);
            ranger.Equip(armor);

            // Act
            string display = ranger.Display();

            // Assert
            Assert.Contains("Name: TestRanger", display);
            Assert.Contains("Class: Ranger", display);
            Assert.Contains("Level: 1", display);
            Assert.Contains("Strength: 3", display);  // 1 (base) + 2 (leather armor)
            Assert.Contains("Dexterity: 11", display);  // 7 (base) + 4 (leather armor)
            Assert.Contains("Intelligence: 2", display);  // 1 (base) + 1 (leather armor)
            Assert.Contains("Damage: 13,32", display);  // 12 (bow) * (1 + 11/100)

            // Additional assertions for equipment
            Assert.Contains("Weapon: TestBow", display);
            Assert.Contains("Body: TestLeather", display);
        }
        [Fact]
        public void Rogue_Display_ShouldReturnCorrectString()
        {
            // Arrange
            Hero rogue = new Rogue("TestRogue");
            Weapon weapon = new Weapon("TestDagger", 1, WeaponType.Dagger);
            Armor armor = new Armor("TestLeather", 1, Slot.Body, ArmorType.Leather);
            rogue.Equip(weapon);
            rogue.Equip(armor);

            // Act
            string display = rogue.Display();

            // Assert
            Assert.Contains("Name: TestRogue", display);
            Assert.Contains("Class: Rogue", display);
            Assert.Contains("Level: 1", display);
            Assert.Contains("Strength: 4", display);  // 2 (base) + 2 (leather armor)
            Assert.Contains("Dexterity: 10", display);  // 6 (base) + 4 (leather armor)
            Assert.Contains("Intelligence: 2", display);  // 1 (base) + 1 (leather armor)
            Assert.Contains("Damage: 4,4", display);  // 4 (dagger) * (1 + 10/100)

            // Additional assertions for equipment
            Assert.Contains("Weapon: TestDagger", display);
            Assert.Contains("Body: TestLeather", display);
        }
        [Fact]
        public void Warrior_Display_ShouldReturnCorrectString()
        {
            // Arrange
            Hero warrior = new Warrior("TestWarrior");
            Weapon weapon = new Weapon("TestAxe", 1, WeaponType.Axe);
            Armor armor = new Armor("TestPlate", 1, Slot.Body, ArmorType.Plate);
            warrior.Equip(weapon);
            warrior.Equip(armor);

            // Act
            string display = warrior.Display();

            // Assert
            Assert.Contains("Name: TestWarrior", display);
            Assert.Contains("Class: Warrior", display);
            Assert.Contains("Level: 1", display);
            Assert.Contains("Strength: 10", display);  // 5 (base) + 5 (plate armor)
            Assert.Contains("Dexterity: 3", display);  // 2 (base) + 1 (plate armor)
            Assert.Contains("Intelligence: 2", display);  // 1 (base) + 1 (plate armor)
            Assert.Contains("Damage: 7,7", display);  // 7 (axe) * (1 + 10/100)

            // Additional assertions for equipment
            Assert.Contains("Weapon: TestAxe", display);
            Assert.Contains("Body: TestPlate", display);
        }
    }
}
