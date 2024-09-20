using RPGHeroes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroesTest
{
    public class HeroDamageTests
    {
        [Fact]
        public void Warrior_Damage_NoWeapon_ShouldReturnCorrectDamage()
        {
            // Arrange
            Hero hero = new Warrior("TestWarrior");
            // Act
            double damage = hero.Damage();
            // Assert
            Assert.Equal(1.05, damage, 2); // 1 * (1 + 5/100) for Warrior
        }

        [Fact]
        public void Mage_Damage_NoWeapon_ShouldReturnCorrectDamage()
        {
            // Arrange
            Hero hero = new Mage("TestMage");
            // Act
            double damage = hero.Damage();
            // Assert
            Assert.Equal(1.08, damage, 2); // 1 * (1 + 8/100) for Mage
        }

        [Fact]
        public void Ranger_Damage_NoWeapon_ShouldReturnCorrectDamage()
        {
            // Arrange
            Hero hero = new Ranger("TestRanger");
            // Act
            double damage = hero.Damage();
            // Assert
            Assert.Equal(1.07, damage, 2); // 1 * (1 + 7/100) for Ranger
        }

        [Fact]
        public void Rogue_Damage_NoWeapon_ShouldReturnCorrectDamage()
        {
            // Arrange
            Hero hero = new Rogue("TestRogue");
            // Act
            double damage = hero.Damage();
            // Assert
            Assert.Equal(1.06, damage, 2); // 1 * (1 + 6/100) for Rogue
        }

        [Fact]
        public void Warrior_Damage_WithWeapon_ShouldReturnCorrectDamage()
        {
            // Arrange
            Hero hero = new Warrior("TestWarrior");
            Weapon weapon = new Weapon("TestAxe", 1, WeaponType.Axe);
            hero.Equip(weapon);
            // Act
            double damage = hero.Damage();
            // Assert
            Assert.Equal(7.35, damage, 2); // 7 * (1 + 5/100) for Warrior with Axe
        }

        [Fact]
        public void Mage_Damage_WithWeapon_ShouldReturnCorrectDamage()
        {
            // Arrange
            Hero hero = new Mage("TestMage");
            Weapon weapon = new Weapon("TestStaff", 1, WeaponType.Staff);
            hero.Equip(weapon);
            // Act
            double damage = hero.Damage();
            // Assert
            Assert.Equal(6.48, damage, 2); // 6 * (1 + 8/100) for Mage with Staff
        }

        [Fact]
        public void Ranger_Damage_WithWeapon_ShouldReturnCorrectDamage()
        {
            // Arrange
            Hero hero = new Ranger("TestRanger");
            Weapon weapon = new Weapon("TestBow", 1, WeaponType.Bow);
            hero.Equip(weapon);
            // Act
            double damage = hero.Damage();
            // Assert
            Assert.Equal(12.84, damage, 2); // 12 * (1 + 7/100) for Ranger with Bow
        }

        [Fact]
        public void Rogue_Damage_WithWeapon_ShouldReturnCorrectDamage()
        {
            // Arrange
            Hero hero = new Rogue("TestRogue");
            Weapon weapon = new Weapon("TestDagger", 1, WeaponType.Dagger);
            hero.Equip(weapon);
            // Act
            double damage = hero.Damage();
            // Assert
            Assert.Equal(4.24, damage, 2); // 4 * (1 + 6/100) for Rogue with Dagger
        }

        [Fact]
        public void Warrior_Damage_ReplacedWeapon_ShouldReturnCorrectDamage()
        {
            // Arrange
            Hero hero = new Warrior("TestWarrior");
            Weapon axe = new Weapon("TestAxe", 1, WeaponType.Axe);
            Weapon sword = new Weapon("TestSword", 1, WeaponType.Sword);
            hero.Equip(axe);
            hero.Equip(sword); // This replaces the axe
            // Act
            double damage = hero.Damage();
            // Assert
            Assert.Equal(5.25, damage, 2); // 5 * (1 + 5/100) for Warrior with Sword
        }

        [Fact]
        public void Mage_Damage_ReplacedWeapon_ShouldReturnCorrectDamage()
        {
            // Arrange
            Hero hero = new Mage("TestMage");
            Weapon staff = new Weapon("TestStaff", 1, WeaponType.Staff);
            Weapon wand = new Weapon("TestWand", 1, WeaponType.Wand);
            hero.Equip(staff);
            hero.Equip(wand); // This replaces the staff
            // Act
            double damage = hero.Damage();
            // Assert
            Assert.Equal(2.16, damage, 2); // 2 * (1 + 8/100) for Mage with Wand
        }
        [Fact]
        public void Ranger_Damage_ReplacedWeapon_ShouldReturnCorrectDamage()
        {
            // Arrange
            Hero hero = new Ranger("TestRanger");
            Weapon bow1 = new Weapon("TestBow1", 1, WeaponType.Bow);
            Weapon bow2 = new Weapon("TestBow2", 1, WeaponType.Bow);
            hero.Equip(bow1);
            hero.Equip(bow2); // This replaces bow1
            // Act
            double damage = hero.Damage();
            // Assert
            Assert.Equal(12.84, damage, 2); // 12 * (1 + 7/100) for Ranger with Bow
        }
        [Fact]
        public void Rogue_Damage_ReplacedWeapon_ShouldReturnCorrectDamage()
        {
            // Arrange
            Hero hero = new Rogue("TestRogue");
            Weapon dagger = new Weapon("TestDagger", 1, WeaponType.Dagger);
            Weapon sword = new Weapon("TestSword", 1, WeaponType.Sword);
            hero.Equip(dagger);
            hero.Equip(sword); // This replaces the dagger
            // Act
            double damage = hero.Damage();
            // Assert
            Assert.Equal(5.30, damage, 2); // 5 * (1 + 6/100) for Rogue with Sword
        }
        [Fact]
        public void Warrior_Damage_WeaponAndArmor_ShouldReturnCorrectDamage()
        {
            // Arrange
            Hero hero = new Warrior("TestWarrior");
            Weapon weapon = new Weapon("TestAxe", 1, WeaponType.Axe);
            Armor armor = new Armor("TestPlate", 1, Slot.Body, ArmorType.Plate);
            hero.Equip(weapon);
            hero.Equip(armor);
            // Act
            double damage = hero.Damage();
            // Assert
            Assert.Equal(7.7, damage, 2); // 7 * (1 + 10/100) for Warrior with Axe and Plate armor
        }

        [Fact]
        public void Mage_Damage_WeaponAndArmor_ShouldReturnCorrectDamage()
        {
            // Arrange
            Hero hero = new Mage("TestMage");
            Weapon weapon = new Weapon("TestStaff", 1, WeaponType.Staff);
            Armor armor = new Armor("TestCloth", 1, Slot.Body, ArmorType.Cloth);
            hero.Equip(weapon);
            hero.Equip(armor);
            // Act
            double damage = hero.Damage();
            // Assert
            Assert.Equal(6.78, damage, 2); // 6 * (1 + 13/100) for Mage with Staff and Cloth armor
        }
        [Fact]
        public void Ranger_Damage_WeaponAndArmor_ShouldReturnCorrectDamage()
        {
            // Arrange
            Hero hero = new Ranger("TestRanger");
            Weapon weapon = new Weapon("TestBow", 1, WeaponType.Bow);
            Armor armor = new Armor("TestLeather", 1, Slot.Body, ArmorType.Leather);
            hero.Equip(weapon);
            hero.Equip(armor);
            // Act
            double damage = hero.Damage();
            // Assert
            Assert.Equal(13.32, damage, 2); // 12 * (1 + 11/100) for Ranger with Bow and Leather armor
        }
        [Fact]
        public void Rogue_Damage_WeaponAndArmor_ShouldReturnCorrectDamage()
        {
            // Arrange
            Hero hero = new Rogue("TestRogue");
            Weapon weapon = new Weapon("TestDagger", 1, WeaponType.Dagger);
            Armor armor = new Armor("TestLeather", 1, Slot.Body, ArmorType.Leather);
            hero.Equip(weapon);
            hero.Equip(armor);
            // Act
            double damage = hero.Damage();
            // Assert
            Assert.Equal(4.40, damage, 2); // 4 * (1 + 10/100) for Rogue with Dagger and Leather armor
        }
    }
}
