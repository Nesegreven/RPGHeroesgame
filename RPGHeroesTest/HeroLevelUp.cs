using RPGHeroes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroesTest
{
    public class HeroLevelUp
    {
        [Fact]
        public void MageLevelUp_ShouldIncreaseAttributesCorrectly()
        {
            // Arrange
            Hero hero = new Mage("TestMage");

            // Act
            hero.LevelUp();

            // Assert
            Assert.Equal(2, hero.Level);
            Assert.Equal(2, hero.LevelAttributes.Strength);
            Assert.Equal(2, hero.LevelAttributes.Dexterity);
            Assert.Equal(13, hero.LevelAttributes.Intelligence);
        }

        [Fact]
        public void RangerLevelUp_ShouldIncreaseAttributesCorrectly()
        {
            // Arrange
            Hero hero = new Ranger("TestRanger");

            // Act
            hero.LevelUp();

            // Assert
            Assert.Equal(2, hero.Level);
            Assert.Equal(2, hero.LevelAttributes.Strength);
            Assert.Equal(12, hero.LevelAttributes.Dexterity);
            Assert.Equal(2, hero.LevelAttributes.Intelligence);
        }

        [Fact]
        public void RogueLevelUp_ShouldIncreaseAttributesCorrectly()
        {
            // Arrange
            Hero hero = new Rogue("TestRogue");

            // Act
            hero.LevelUp();

            // Assert
            Assert.Equal(2, hero.Level);
            Assert.Equal(3, hero.LevelAttributes.Strength);
            Assert.Equal(10, hero.LevelAttributes.Dexterity);
            Assert.Equal(2, hero.LevelAttributes.Intelligence);
        }

        [Fact]
        public void WarriorLevelUp_ShouldIncreaseAttributesCorrectly()
        {
            // Arrange
            Hero hero = new Warrior("TestWarrior");

            // Act
            hero.LevelUp();

            // Assert
            Assert.Equal(2, hero.Level);
            Assert.Equal(8, hero.LevelAttributes.Strength);
            Assert.Equal(4, hero.LevelAttributes.Dexterity);
            Assert.Equal(2, hero.LevelAttributes.Intelligence);
        }
    }
}
