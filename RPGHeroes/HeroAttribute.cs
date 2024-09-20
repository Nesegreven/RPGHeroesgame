using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes
{
    public class HeroAttribute
    {   //Represents the attributes of a hero in the game. and used to get and set the attributes
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }

        public HeroAttribute(int strength, int dexterity, int intelligence)  //Initializes a new instance of the HeroAttribute class.
        {
            Strength = strength;
            Dexterity = dexterity;
            Intelligence = intelligence;
        }

        public static HeroAttribute operator +(HeroAttribute a, HeroAttribute b) //Overloads the addition operator to add two HeroAttribute instances.
        {
            return new HeroAttribute(                                           //A new HeroAttribute instance with summed attributes, used by armor to modify the attribues of a hero when equipping
                a.Strength + b.Strength,
                a.Dexterity + b.Dexterity,
                a.Intelligence + b.Intelligence
            );
        }
    }
}
