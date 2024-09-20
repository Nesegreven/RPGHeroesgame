using RPGHeroes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroesTest
{
    public class TotalAttributesTest
    {
        [Fact]
        public void Warrior_TotalAttributes_NoEquipment_ShouldReturnLevelAttributes()
        {
            // Arrange
            Hero hero = new Warrior("TestHero");
            int expectedStrength = 5;
            int expectedDexterity = 2;
            int expectedIntelligence = 1;

            // Act
            HeroAttribute totalAttr = hero.TotalAttributes();

            // Assert
            Assert.Equal(expectedStrength, totalAttr.Strength);
            Assert.Equal(expectedDexterity, totalAttr.Dexterity);
            Assert.Equal(expectedIntelligence, totalAttr.Intelligence);
        }

        [Fact]
        public void Warrior_TotalAttributes_WithArmor_ShouldReturnCorrectAttributes()
        {
            // Arrange
            Hero hero = new Warrior("TestHero");
            Armor armor = new Armor("TestPlate", 1, Slot.Body, ArmorType.Plate);
            hero.Equip(armor);
            int expectedStrength = 10; // 5 (base) + 5 (plate armor)
            int expectedDexterity = 3; // 2 (base) + 1 (plate armor)
            int expectedIntelligence = 2; // 1 (base) + 1 (plate armor)

            // Act
            HeroAttribute totalAttr = hero.TotalAttributes();

            // Assert
            Assert.Equal(expectedStrength, totalAttr.Strength);
            Assert.Equal(expectedDexterity, totalAttr.Dexterity);
            Assert.Equal(expectedIntelligence, totalAttr.Intelligence);
        }
        [Fact]
        public void Warrior_TotalAttributes_WithTwoPiecesOfArmor_ShouldReturnCorrectAttributes()
        {
            // Arrange
            Hero hero = new Warrior("TestHero");
            Armor bodyArmor = new Armor("TestPlateBody", 1, Slot.Body, ArmorType.Plate);
            Armor headArmor = new Armor("TestPlateHelmet", 1, Slot.Head, ArmorType.Plate);
            hero.Equip(bodyArmor);
            hero.Equip(headArmor);
            int expectedStrength = 15; // 5 (base) + 5 (plate body) + 5 (plate helmet)
            int expectedDexterity = 4; // 2 (base) + 1 (plate body) + 1 (plate helmet)
            int expectedIntelligence = 3; // 1 (base) + 1 (plate body) + 1 (plate helmet)

            // Act
            HeroAttribute totalAttr = hero.TotalAttributes();

            // Assert
            Assert.Equal(expectedStrength, totalAttr.Strength);
            Assert.Equal(expectedDexterity, totalAttr.Dexterity);
            Assert.Equal(expectedIntelligence, totalAttr.Intelligence);
        }

        [Fact]
        public void Warrior_TotalAttributes_ReplacingArmor_ShouldReturnCorrectAttributes()
        {
            // Arrange
            Hero hero = new Warrior("TestHero");
            Armor plateArmor = new Armor("TestPlateBody", 1, Slot.Body, ArmorType.Plate);
            Armor mailArmor = new Armor("TestMailBody", 1, Slot.Body, ArmorType.Mail);

            hero.Equip(plateArmor);
            hero.Equip(mailArmor); // This replaces the plate armor

            int expectedStrength = 8; // 5 (base) + 3 (mail armor)
            int expectedDexterity = 4; // 2 (base) + 2 (mail armor)
            int expectedIntelligence = 2; // 1 (base) + 1 (mail armor)

            // Act
            HeroAttribute totalAttr = hero.TotalAttributes();

            // Assert
            Assert.Equal(expectedStrength, totalAttr.Strength);
            Assert.Equal(expectedDexterity, totalAttr.Dexterity);
            Assert.Equal(expectedIntelligence, totalAttr.Intelligence);
        }
        [Fact]
        public void Mage_TotalAttributes_NoEquipment_ShouldReturnLevelAttributes()
        {
            // Arrange
            Hero mage = new Mage("TestMage");
            int expectedStrength = 1;
            int expectedDexterity = 1;
            int expectedIntelligence = 8;

            // Act
            HeroAttribute totalAttr = mage.TotalAttributes();

            // Assert
            Assert.Equal(expectedStrength, totalAttr.Strength);
            Assert.Equal(expectedDexterity, totalAttr.Dexterity);
            Assert.Equal(expectedIntelligence, totalAttr.Intelligence);
        }

        [Fact]
        public void Mage_TotalAttributes_WithArmor_ShouldReturnCorrectAttributes()
        {
            // Arrange
            Hero mage = new Mage("TestMage");
            Armor armor = new Armor("TestCloth", 1, Slot.Body, ArmorType.Cloth);
            mage.Equip(armor);
            int expectedStrength = 2; // 1 (base) + 1 (cloth armor)
            int expectedDexterity = 2; // 1 (base) + 1 (cloth armor)
            int expectedIntelligence = 13; // 8 (base) + 5 (cloth armor)

            // Act
            HeroAttribute totalAttr = mage.TotalAttributes();

            // Assert
            Assert.Equal(expectedStrength, totalAttr.Strength);
            Assert.Equal(expectedDexterity, totalAttr.Dexterity);
            Assert.Equal(expectedIntelligence, totalAttr.Intelligence);
        }

        [Fact]
        public void Mage_TotalAttributes_WithTwoPiecesOfArmor_ShouldReturnCorrectAttributes()
        {
            // Arrange
            Hero mage = new Mage("TestMage");
            Armor bodyArmor = new Armor("TestClothBody", 1, Slot.Body, ArmorType.Cloth);
            Armor headArmor = new Armor("TestClothHat", 1, Slot.Head, ArmorType.Cloth);
            mage.Equip(bodyArmor);
            mage.Equip(headArmor);
            int expectedStrength = 3; // 1 (base) + 1 (cloth body) + 1 (cloth hat)
            int expectedDexterity = 3; // 1 (base) + 1 (cloth body) + 1 (cloth hat)
            int expectedIntelligence = 18; // 8 (base) + 5 (cloth body) + 5 (cloth hat)

            // Act
            HeroAttribute totalAttr = mage.TotalAttributes();

            // Assert
            Assert.Equal(expectedStrength, totalAttr.Strength);
            Assert.Equal(expectedDexterity, totalAttr.Dexterity);
            Assert.Equal(expectedIntelligence, totalAttr.Intelligence);
        }

        [Fact]
        public void Mage_TotalAttributes_ReplacingArmor_ShouldReturnCorrectAttributes()
        {
            // Arrange
            Hero mage = new Mage("TestMage");
            Armor clothArmor = new Armor("TestClothBody", 1, Slot.Body, ArmorType.Cloth);
            Armor newClothArmor = new Armor("TestNewClothBody", 1, Slot.Body, ArmorType.Cloth);
            mage.Equip(clothArmor);
            mage.Equip(newClothArmor); // This replaces the first cloth armor
            int expectedStrength = 2; // 1 (base) + 1 (new cloth armor)
            int expectedDexterity = 2; // 1 (base) + 1 (new cloth armor)
            int expectedIntelligence = 13; // 8 (base) + 5 (new cloth armor)

            // Act
            HeroAttribute totalAttr = mage.TotalAttributes();

            // Assert
            Assert.Equal(expectedStrength, totalAttr.Strength);
            Assert.Equal(expectedDexterity, totalAttr.Dexterity);
            Assert.Equal(expectedIntelligence, totalAttr.Intelligence);
        }
        [Fact]
        public void Ranger_TotalAttributes_NoEquipment_ShouldReturnLevelAttributes()
        {
            // Arrange
            Hero ranger = new Ranger("TestRanger");
            int expectedStrength = 1;
            int expectedDexterity = 7;
            int expectedIntelligence = 1;

            // Act
            HeroAttribute totalAttr = ranger.TotalAttributes();

            // Assert
            Assert.Equal(expectedStrength, totalAttr.Strength);
            Assert.Equal(expectedDexterity, totalAttr.Dexterity);
            Assert.Equal(expectedIntelligence, totalAttr.Intelligence);
        }

        [Fact]
        public void Ranger_TotalAttributes_WithLeatherArmor_ShouldReturnCorrectAttributes()
        {
            // Arrange
            Hero ranger = new Ranger("TestRanger");
            Armor armor = new Armor("TestLeather", 1, Slot.Body, ArmorType.Leather);
            ranger.Equip(armor);
            int expectedStrength = 3; // 1 (base) + 2 (leather armor)
            int expectedDexterity = 11; // 7 (base) + 4 (leather armor)
            int expectedIntelligence = 2; // 1 (base) + 1 (leather armor)

            // Act
            HeroAttribute totalAttr = ranger.TotalAttributes();

            // Assert
            Assert.Equal(expectedStrength, totalAttr.Strength);
            Assert.Equal(expectedDexterity, totalAttr.Dexterity);
            Assert.Equal(expectedIntelligence, totalAttr.Intelligence);
        }

        [Fact]
        public void Ranger_TotalAttributes_WithTwoPiecesOfArmor_ShouldReturnCorrectAttributes()
        {
            // Arrange
            Hero ranger = new Ranger("TestRanger");
            Armor bodyArmor = new Armor("TestLeatherBody", 1, Slot.Body, ArmorType.Leather);
            Armor headArmor = new Armor("TestMailHelmet", 1, Slot.Head, ArmorType.Mail);
            ranger.Equip(bodyArmor);
            ranger.Equip(headArmor);
            int expectedStrength = 6; // 1 (base) + 2 (leather body) + 3 (mail helmet)
            int expectedDexterity = 13; // 7 (base) + 4 (leather body) + 2 (mail helmet)
            int expectedIntelligence = 3; // 1 (base) + 1 (leather body) + 1 (mail helmet)

            // Act
            HeroAttribute totalAttr = ranger.TotalAttributes();

            // Assert
            Assert.Equal(expectedStrength, totalAttr.Strength);
            Assert.Equal(expectedDexterity, totalAttr.Dexterity);
            Assert.Equal(expectedIntelligence, totalAttr.Intelligence);
        }

        [Fact]
        public void Ranger_TotalAttributes_ReplacingArmor_ShouldReturnCorrectAttributes()
        {
            // Arrange
            Hero ranger = new Ranger("TestRanger");
            Armor leatherArmor = new Armor("TestLeatherBody", 1, Slot.Body, ArmorType.Leather);
            Armor mailArmor = new Armor("TestMailBody", 1, Slot.Body, ArmorType.Mail);
            ranger.Equip(leatherArmor);
            ranger.Equip(mailArmor); // This replaces the leather armor
            int expectedStrength = 4; // 1 (base) + 3 (mail armor)
            int expectedDexterity = 9; // 7 (base) + 2 (mail armor)
            int expectedIntelligence = 2; // 1 (base) + 1 (mail armor)

            // Act
            HeroAttribute totalAttr = ranger.TotalAttributes();

            // Assert
            Assert.Equal(expectedStrength, totalAttr.Strength);
            Assert.Equal(expectedDexterity, totalAttr.Dexterity);
            Assert.Equal(expectedIntelligence, totalAttr.Intelligence);
        }
        [Fact]
        public void Rogue_TotalAttributes_NoEquipment_ShouldReturnLevelAttributes()
        {
            // Arrange
            Hero rogue = new Rogue("TestRogue");
            int expectedStrength = 2;
            int expectedDexterity = 6;
            int expectedIntelligence = 1;

            // Act
            HeroAttribute totalAttr = rogue.TotalAttributes();

            // Assert
            Assert.Equal(expectedStrength, totalAttr.Strength);
            Assert.Equal(expectedDexterity, totalAttr.Dexterity);
            Assert.Equal(expectedIntelligence, totalAttr.Intelligence);
        }

        [Fact]
        public void Rogue_TotalAttributes_WithLeatherArmor_ShouldReturnCorrectAttributes()
        {
            // Arrange
            Hero rogue = new Rogue("TestRogue");
            Armor armor = new Armor("TestLeather", 1, Slot.Body, ArmorType.Leather);
            rogue.Equip(armor);
            int expectedStrength = 4; // 2 (base) + 2 (leather armor)
            int expectedDexterity = 10; // 6 (base) + 4 (leather armor)
            int expectedIntelligence = 2; // 1 (base) + 1 (leather armor)

            // Act
            HeroAttribute totalAttr = rogue.TotalAttributes();

            // Assert
            Assert.Equal(expectedStrength, totalAttr.Strength);
            Assert.Equal(expectedDexterity, totalAttr.Dexterity);
            Assert.Equal(expectedIntelligence, totalAttr.Intelligence);
        }

        [Fact]
        public void Rogue_TotalAttributes_WithTwoPiecesOfArmor_ShouldReturnCorrectAttributes()
        {
            // Arrange
            Hero rogue = new Rogue("TestRogue");
            Armor bodyArmor = new Armor("TestLeatherBody", 1, Slot.Body, ArmorType.Leather);
            Armor headArmor = new Armor("TestMailHelmet", 1, Slot.Head, ArmorType.Mail);
            rogue.Equip(bodyArmor);
            rogue.Equip(headArmor);
            int expectedStrength = 7; // 2 (base) + 2 (leather body) + 3 (mail helmet)
            int expectedDexterity = 12; // 6 (base) + 4 (leather body) + 2 (mail helmet)
            int expectedIntelligence = 3; // 1 (base) + 1 (leather body) + 1 (mail helmet)

            // Act
            HeroAttribute totalAttr = rogue.TotalAttributes();

            // Assert
            Assert.Equal(expectedStrength, totalAttr.Strength);
            Assert.Equal(expectedDexterity, totalAttr.Dexterity);
            Assert.Equal(expectedIntelligence, totalAttr.Intelligence);
        }

        [Fact]
        public void Rogue_TotalAttributes_ReplacingArmor_ShouldReturnCorrectAttributes()
        {
            // Arrange
            Hero rogue = new Rogue("TestRogue");
            Armor leatherArmor = new Armor("TestLeatherBody", 1, Slot.Body, ArmorType.Leather);
            Armor mailArmor = new Armor("TestMailBody", 1, Slot.Body, ArmorType.Mail);
            rogue.Equip(leatherArmor);
            rogue.Equip(mailArmor); // This replaces the leather armor
            int expectedStrength = 5; // 2 (base) + 3 (mail armor)
            int expectedDexterity = 8; // 6 (base) + 2 (mail armor)
            int expectedIntelligence = 2; // 1 (base) + 1 (mail armor)

            // Act
            HeroAttribute totalAttr = rogue.TotalAttributes();

            // Assert
            Assert.Equal(expectedStrength, totalAttr.Strength);
            Assert.Equal(expectedDexterity, totalAttr.Dexterity);
            Assert.Equal(expectedIntelligence, totalAttr.Intelligence);
        }
    }
}

