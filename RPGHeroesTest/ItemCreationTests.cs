using RPGHeroes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroesTest
{
    public class ItemCreationTests
    {
        

        [Fact]
        public void ClothArmorCreation_ShouldHaveCorrectProperties()
        {
            // Arrange
            string name = "Common Cloth Vest";
            int requiredLevel = 1;
            Slot slot = Slot.Body;
            ArmorType armorType = ArmorType.Cloth;

            // Act
            Armor armor = new Armor(name, requiredLevel, slot, armorType);

            // Assert
            Assert.Equal(name, armor.Name);
            Assert.Equal(requiredLevel, armor.RequiredLevel);
            Assert.Equal(slot, armor.Slot);
            Assert.Equal(armorType, armor.ArmorType);
            Assert.Equal(1, armor.ArmorAttribute.Strength);
            Assert.Equal(1, armor.ArmorAttribute.Dexterity);
            Assert.Equal(5, armor.ArmorAttribute.Intelligence);
        }

        [Fact]
        public void LeatherArmorCreation_ShouldHaveCorrectProperties()
        {
            // Arrange
            string name = "Common Leather Pants";
            int requiredLevel = 1;
            Slot slot = Slot.Legs;
            ArmorType armorType = ArmorType.Leather;

            // Act
            Armor armor = new Armor(name, requiredLevel, slot, armorType);

            // Assert
            Assert.Equal(name, armor.Name);
            Assert.Equal(requiredLevel, armor.RequiredLevel);
            Assert.Equal(slot, armor.Slot);
            Assert.Equal(armorType, armor.ArmorType);
            Assert.Equal(2, armor.ArmorAttribute.Strength);
            Assert.Equal(4, armor.ArmorAttribute.Dexterity);
            Assert.Equal(1, armor.ArmorAttribute.Intelligence);
        }

        [Fact]
        public void MailArmorCreation_ShouldHaveCorrectProperties()
        {
            // Arrange
            string name = "Common Mail Helmet";
            int requiredLevel = 1;
            Slot slot = Slot.Head;
            ArmorType armorType = ArmorType.Mail;

            // Act
            Armor armor = new Armor(name, requiredLevel, slot, armorType);

            // Assert
            Assert.Equal(name, armor.Name);
            Assert.Equal(requiredLevel, armor.RequiredLevel);
            Assert.Equal(slot, armor.Slot);
            Assert.Equal(armorType, armor.ArmorType);
            Assert.Equal(3, armor.ArmorAttribute.Strength);
            Assert.Equal(2, armor.ArmorAttribute.Dexterity);
            Assert.Equal(1, armor.ArmorAttribute.Intelligence);
        }

        [Fact]
        public void PlateArmorCreation_ShouldHaveCorrectProperties()
        {
            // Arrange
            string name = "Common Plate Body Armor";
            int requiredLevel = 1;
            Slot slot = Slot.Body;
            ArmorType armorType = ArmorType.Plate;

            // Act
            Armor armor = new Armor(name, requiredLevel, slot, armorType);

            // Assert
            Assert.Equal(name, armor.Name);
            Assert.Equal(requiredLevel, armor.RequiredLevel);
            Assert.Equal(slot, armor.Slot);
            Assert.Equal(armorType, armor.ArmorType);
            Assert.Equal(5, armor.ArmorAttribute.Strength);
            Assert.Equal(1, armor.ArmorAttribute.Dexterity);
            Assert.Equal(1, armor.ArmorAttribute.Intelligence);
        }

        

        

        [Fact]
        public void AxeCreation_ShouldHaveCorrectProperties()
        {
            // Arrange
            string name = "Common Axe";
            int requiredLevel = 1;
            WeaponType weaponType = WeaponType.Axe;

            // Act
            Weapon weapon = new Weapon(name, requiredLevel, weaponType);

            // Assert
            Assert.Equal(name, weapon.Name);
            Assert.Equal(requiredLevel, weapon.RequiredLevel);
            Assert.Equal(Slot.Weapon, weapon.Slot);
            Assert.Equal(weaponType, weapon.WeaponType);
            Assert.Equal(7, weapon.WeaponDamage);
        }

        [Fact]
        public void BowCreation_ShouldHaveCorrectProperties()
        {
            // Arrange
            string name = "Common Bow";
            int requiredLevel = 1;
            WeaponType weaponType = WeaponType.Bow;

            // Act
            Weapon weapon = new Weapon(name, requiredLevel, weaponType);

            // Assert
            Assert.Equal(name, weapon.Name);
            Assert.Equal(requiredLevel, weapon.RequiredLevel);
            Assert.Equal(Slot.Weapon, weapon.Slot);
            Assert.Equal(weaponType, weapon.WeaponType);
            Assert.Equal(12, weapon.WeaponDamage);
        }

        [Fact]
        public void DaggerCreation_ShouldHaveCorrectProperties()
        {
            // Arrange
            string name = "Common Dagger";
            int requiredLevel = 1;
            WeaponType weaponType = WeaponType.Dagger;

            // Act
            Weapon weapon = new Weapon(name, requiredLevel, weaponType);

            // Assert
            Assert.Equal(name, weapon.Name);
            Assert.Equal(requiredLevel, weapon.RequiredLevel);
            Assert.Equal(Slot.Weapon, weapon.Slot);
            Assert.Equal(weaponType, weapon.WeaponType);
            Assert.Equal(4, weapon.WeaponDamage);
        }

        [Fact]
        public void HammerCreation_ShouldHaveCorrectProperties()
        {
            // Arrange
            string name = "Common Hammer";
            int requiredLevel = 1;
            WeaponType weaponType = WeaponType.Hammer;

            // Act
            Weapon weapon = new Weapon(name, requiredLevel, weaponType);

            // Assert
            Assert.Equal(name, weapon.Name);
            Assert.Equal(requiredLevel, weapon.RequiredLevel);
            Assert.Equal(Slot.Weapon, weapon.Slot);
            Assert.Equal(weaponType, weapon.WeaponType);
            Assert.Equal(10, weapon.WeaponDamage);
        }

        [Fact]
        public void StaffCreation_ShouldHaveCorrectProperties()
        {
            // Arrange
            string name = "Common Staff";
            int requiredLevel = 1;
            WeaponType weaponType = WeaponType.Staff;

            // Act
            Weapon weapon = new Weapon(name, requiredLevel, weaponType);

            // Assert
            Assert.Equal(name, weapon.Name);
            Assert.Equal(requiredLevel, weapon.RequiredLevel);
            Assert.Equal(Slot.Weapon, weapon.Slot);
            Assert.Equal(weaponType, weapon.WeaponType);
            Assert.Equal(6, weapon.WeaponDamage);
        }

        [Fact]
        public void SwordCreation_ShouldHaveCorrectProperties()
        {
            // Arrange
            string name = "Common Sword";
            int requiredLevel = 1;
            WeaponType weaponType = WeaponType.Sword;

            // Act
            Weapon weapon = new Weapon(name, requiredLevel, weaponType);

            // Assert
            Assert.Equal(name, weapon.Name);
            Assert.Equal(requiredLevel, weapon.RequiredLevel);
            Assert.Equal(Slot.Weapon, weapon.Slot);
            Assert.Equal(weaponType, weapon.WeaponType);
            Assert.Equal(5, weapon.WeaponDamage);
        }

        [Fact]
        public void WandCreation_ShouldHaveCorrectProperties()
        {
            // Arrange
            string name = "Common Wand";
            int requiredLevel = 1;
            WeaponType weaponType = WeaponType.Wand;

            // Act
            Weapon weapon = new Weapon(name, requiredLevel, weaponType);

            // Assert
            Assert.Equal(name, weapon.Name);
            Assert.Equal(requiredLevel, weapon.RequiredLevel);
            Assert.Equal(Slot.Weapon, weapon.Slot);
            Assert.Equal(weaponType, weapon.WeaponType);
            Assert.Equal(2, weapon.WeaponDamage);
        }

       
    }
}
