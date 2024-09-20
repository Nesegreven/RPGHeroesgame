using RPGHeroes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroesTest
{
    public class HeroEquipmentTests
    {
        [Fact]
        public void Warrior_EquipWeapon_Valid_ShouldNotThrowException()
        {
            // Arrange
            Hero hero = new Warrior("TestHero");
            Weapon weapon = new Weapon("TestAxe", 1, WeaponType.Axe);

            // Act
            hero.Equip(weapon);

            // Assert
            Assert.Equal(weapon, hero.Equipment[Slot.Weapon]);
        }

        [Fact]
        public void Warrior_EquipWeapon_InvalidLevel_ShouldThrowException()
        {
            // Arrange
            Hero hero = new Warrior("TestHero");
            Weapon weapon = new Weapon("TestAxe", 2, WeaponType.Axe);

            // Act & Assert
            Assert.Throws<InvalidWeaponException>(() => hero.Equip(weapon));
        }

        [Fact]
        public void Warrior_EquipWeapon_InvalidType_ShouldThrowException()
        {
            // Arrange
            Hero hero = new Warrior("TestHero");
            Weapon weapon = new Weapon("TestBow", 1, WeaponType.Bow);

            // Act & Assert
            Assert.Throws<InvalidWeaponException>(() => hero.Equip(weapon));
        }

        [Fact]
        public void Warrior_EquipArmor_Valid_ShouldNotThrowException()
        {
            // Arrange
            Hero hero = new Warrior("TestHero");
            Armor armor = new Armor("TestPlate", 1, Slot.Body, ArmorType.Plate);

            // Act
            hero.Equip(armor);

            // Assert
            Assert.Equal(armor, hero.Equipment[Slot.Body]);
        }

        [Fact]
        public void Warrior_EquipArmor_InvalidLevel_ShouldThrowException()
        {
            // Arrange
            Hero hero = new Warrior("TestHero");
            Armor armor = new Armor("TestPlate", 2, Slot.Body, ArmorType.Plate);

            // Act & Assert
            Assert.Throws<InvalidArmorException>(() => hero.Equip(armor));
        }

        [Fact]
        public void Warrior_EquipArmor_InvalidType_ShouldThrowException()
        {
            // Arrange
            Hero hero = new Warrior("TestHero");
            Armor armor = new Armor("TestCloth", 1, Slot.Body, ArmorType.Cloth);

            // Act & Assert
            Assert.Throws<InvalidArmorException>(() => hero.Equip(armor));
        }
        [Fact]
        public void Mage_EquipWeapon_Valid_ShouldNotThrowException()
        {
            // Arrange
            Hero mage = new Mage("TestMage");
            Weapon weapon = new Weapon("TestStaff", 1, WeaponType.Staff);
            // Act
            mage.Equip(weapon);
            // Assert
            Assert.Equal(weapon, mage.Equipment[Slot.Weapon]);
        }

        [Fact]
        public void Mage_EquipWeapon_InvalidLevel_ShouldThrowException()
        {
            // Arrange
            Hero mage = new Mage("TestMage");
            Weapon weapon = new Weapon("TestStaff", 2, WeaponType.Staff);
            // Act & Assert
            Assert.Throws<InvalidWeaponException>(() => mage.Equip(weapon));
        }

        [Fact]
        public void Mage_EquipWeapon_InvalidType_ShouldThrowException()
        {
            // Arrange
            Hero mage = new Mage("TestMage");
            Weapon weapon = new Weapon("TestSword", 1, WeaponType.Sword);
            // Act & Assert
            Assert.Throws<InvalidWeaponException>(() => mage.Equip(weapon));
        }

        [Fact]
        public void Mage_EquipArmor_Valid_ShouldNotThrowException()
        {
            // Arrange
            Hero mage = new Mage("TestMage");
            Armor armor = new Armor("TestCloth", 1, Slot.Body, ArmorType.Cloth);
            // Act
            mage.Equip(armor);
            // Assert
            Assert.Equal(armor, mage.Equipment[Slot.Body]);
        }

        [Fact]
        public void Mage_EquipArmor_InvalidLevel_ShouldThrowException()
        {
            // Arrange
            Hero mage = new Mage("TestMage");
            Armor armor = new Armor("TestCloth", 2, Slot.Body, ArmorType.Cloth);
            // Act & Assert
            Assert.Throws<InvalidArmorException>(() => mage.Equip(armor));
        }

        [Fact]
        public void Mage_EquipArmor_InvalidType_ShouldThrowException()
        {
            // Arrange
            Hero mage = new Mage("TestMage");
            Armor armor = new Armor("TestPlate", 1, Slot.Body, ArmorType.Plate);
            // Act & Assert
            Assert.Throws<InvalidArmorException>(() => mage.Equip(armor));
        }
        [Fact]
        public void Ranger_EquipWeapon_Valid_ShouldNotThrowException()
        {
            // Arrange
            Hero ranger = new Ranger("TestRanger");
            Weapon weapon = new Weapon("TestBow", 1, WeaponType.Bow);
            // Act
            ranger.Equip(weapon);
            // Assert
            Assert.Equal(weapon, ranger.Equipment[Slot.Weapon]);
        }

        [Fact]
        public void Ranger_EquipWeapon_InvalidLevel_ShouldThrowException()
        {
            // Arrange
            Hero ranger = new Ranger("TestRanger");
            Weapon weapon = new Weapon("TestBow", 2, WeaponType.Bow);
            // Act & Assert
            Assert.Throws<InvalidWeaponException>(() => ranger.Equip(weapon));
        }

        [Fact]
        public void Ranger_EquipWeapon_InvalidType_ShouldThrowException()
        {
            // Arrange
            Hero ranger = new Ranger("TestRanger");
            Weapon weapon = new Weapon("TestSword", 1, WeaponType.Sword);
            // Act & Assert
            Assert.Throws<InvalidWeaponException>(() => ranger.Equip(weapon));
        }

        [Fact]
        public void Ranger_EquipArmor_ValidLeather_ShouldNotThrowException()
        {
            // Arrange
            Hero ranger = new Ranger("TestRanger");
            Armor armor = new Armor("TestLeather", 1, Slot.Body, ArmorType.Leather);
            // Act
            ranger.Equip(armor);
            // Assert
            Assert.Equal(armor, ranger.Equipment[Slot.Body]);
        }

        [Fact]
        public void Ranger_EquipArmor_ValidMail_ShouldNotThrowException()
        {
            // Arrange
            Hero ranger = new Ranger("TestRanger");
            Armor armor = new Armor("TestMail", 1, Slot.Body, ArmorType.Mail);
            // Act
            ranger.Equip(armor);
            // Assert
            Assert.Equal(armor, ranger.Equipment[Slot.Body]);
        }

        [Fact]
        public void Ranger_EquipArmor_InvalidLevel_ShouldThrowException()
        {
            // Arrange
            Hero ranger = new Ranger("TestRanger");
            Armor armor = new Armor("TestLeather", 2, Slot.Body, ArmorType.Leather);
            // Act & Assert
            Assert.Throws<InvalidArmorException>(() => ranger.Equip(armor));
        }

        [Fact]
        public void Ranger_EquipArmor_InvalidType_ShouldThrowException()
        {
            // Arrange
            Hero ranger = new Ranger("TestRanger");
            Armor armor = new Armor("TestPlate", 1, Slot.Body, ArmorType.Plate);
            // Act & Assert
            Assert.Throws<InvalidArmorException>(() => ranger.Equip(armor));
        }
        [Fact]
        public void Rogue_EquipWeapon_ValidDagger_ShouldNotThrowException()
        {
            // Arrange
            Hero rogue = new Rogue("TestRogue");
            Weapon weapon = new Weapon("TestDagger", 1, WeaponType.Dagger);
            // Act
            rogue.Equip(weapon);
            // Assert
            Assert.Equal(weapon, rogue.Equipment[Slot.Weapon]);
        }

        [Fact]
        public void Rogue_EquipWeapon_ValidSword_ShouldNotThrowException()
        {
            // Arrange
            Hero rogue = new Rogue("TestRogue");
            Weapon weapon = new Weapon("TestSword", 1, WeaponType.Sword);
            // Act
            rogue.Equip(weapon);
            // Assert
            Assert.Equal(weapon, rogue.Equipment[Slot.Weapon]);
        }

        [Fact]
        public void Rogue_EquipWeapon_InvalidLevel_ShouldThrowException()
        {
            // Arrange
            Hero rogue = new Rogue("TestRogue");
            Weapon weapon = new Weapon("TestDagger", 2, WeaponType.Dagger);
            // Act & Assert
            Assert.Throws<InvalidWeaponException>(() => rogue.Equip(weapon));
        }

        [Fact]
        public void Rogue_EquipWeapon_InvalidType_ShouldThrowException()
        {
            // Arrange
            Hero rogue = new Rogue("TestRogue");
            Weapon weapon = new Weapon("TestAxe", 1, WeaponType.Axe);
            // Act & Assert
            Assert.Throws<InvalidWeaponException>(() => rogue.Equip(weapon));
        }

        [Fact]
        public void Rogue_EquipArmor_ValidLeather_ShouldNotThrowException()
        {
            // Arrange
            Hero rogue = new Rogue("TestRogue");
            Armor armor = new Armor("TestLeather", 1, Slot.Body, ArmorType.Leather);
            // Act
            rogue.Equip(armor);
            // Assert
            Assert.Equal(armor, rogue.Equipment[Slot.Body]);
        }

        [Fact]
        public void Rogue_EquipArmor_ValidMail_ShouldNotThrowException()
        {
            // Arrange
            Hero rogue = new Rogue("TestRogue");
            Armor armor = new Armor("TestMail", 1, Slot.Body, ArmorType.Mail);
            // Act
            rogue.Equip(armor);
            // Assert
            Assert.Equal(armor, rogue.Equipment[Slot.Body]);
        }

        [Fact]
        public void Rogue_EquipArmor_InvalidLevel_ShouldThrowException()
        {
            // Arrange
            Hero rogue = new Rogue("TestRogue");
            Armor armor = new Armor("TestLeather", 2, Slot.Body, ArmorType.Leather);
            // Act & Assert
            Assert.Throws<InvalidArmorException>(() => rogue.Equip(armor));
        }

        [Fact]
        public void Rogue_EquipArmor_InvalidType_ShouldThrowException()
        {
            // Arrange
            Hero rogue = new Rogue("TestRogue");
            Armor armor = new Armor("TestPlate", 1, Slot.Body, ArmorType.Plate);
            // Act & Assert
            Assert.Throws<InvalidArmorException>(() => rogue.Equip(armor));
        }
    }
}