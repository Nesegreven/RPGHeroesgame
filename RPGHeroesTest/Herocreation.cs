using RPGHeroes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroesTest
{
    public class Herocreation
    {

        [Fact]
        public void MageCreation_ShouldHaveCorrectInitialAttributes()
        {
            // Arrange
            string name = "TestMage";

            // Act
            Hero hero = new Mage(name);

            // Assert
            Assert.Equal(name, hero.Name);
            Assert.Equal(1, hero.Level);
            Assert.Equal(1, hero.LevelAttributes.Strength);
            Assert.Equal(1, hero.LevelAttributes.Dexterity);
            Assert.Equal(8, hero.LevelAttributes.Intelligence);
        }

        [Fact]
        public void RangerCreation_ShouldHaveCorrectInitialAttributes()
        {
            // Arrange
            string name = "TestRanger";

            // Act
            Hero hero = new Ranger(name);

            // Assert
            Assert.Equal(name, hero.Name);
            Assert.Equal(1, hero.Level);
            Assert.Equal(1, hero.LevelAttributes.Strength);
            Assert.Equal(7, hero.LevelAttributes.Dexterity);
            Assert.Equal(1, hero.LevelAttributes.Intelligence);
        }

        [Fact]
        public void RogueCreation_ShouldHaveCorrectInitialAttributes()
        {
            // Arrange
            string name = "TestRogue";

            // Act
            Hero hero = new Rogue(name);

            // Assert
            Assert.Equal(name, hero.Name);
            Assert.Equal(1, hero.Level);
            Assert.Equal(2, hero.LevelAttributes.Strength);
            Assert.Equal(6, hero.LevelAttributes.Dexterity);
            Assert.Equal(1, hero.LevelAttributes.Intelligence);
        }

        [Fact]
        public void WarriorCreation_ShouldHaveCorrectInitialAttributes()
        {
            // Arrange
            string name = "TestWarrior";

            // Act
            Hero hero = new Warrior(name);

            // Assert
            Assert.Equal(name, hero.Name);
            Assert.Equal(1, hero.Level);
            Assert.Equal(5, hero.LevelAttributes.Strength);
            Assert.Equal(2, hero.LevelAttributes.Dexterity);
            Assert.Equal(1, hero.LevelAttributes.Intelligence);
        }
    }
}
