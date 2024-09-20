using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes //read that i could be good practice to have all enums in a file like classes,
                    //espcially when project is large, but they could be contained in related classes for smaller projects

{
    public enum Slot // Represents the equipment slots available for a hero.
    {
        Weapon,
        Head,
        Body,
        Legs
    }

    public enum WeaponType // Represents the types of weapons available in the game.

    {
        Axe,
        Bow,
        Dagger,
        Hammer,
        Staff,
        Sword,
        Wand
    }

    public enum ArmorType // Represents the types of armor available in the game.
    {
        Cloth,
        Leather,
        Mail,
        Plate
    }
}