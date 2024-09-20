using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes
{
    public abstract class Item  //Abstract base class for all items in the game.
    {
        public string Name { get; protected set; }
        public int RequiredLevel { get; protected set; }
        public Slot Slot { get; protected set; }

        protected Item(string name, int requiredLevel, Slot slot)
        {
            Name = name;
            RequiredLevel = requiredLevel;
            Slot = slot;
        }
    }
}
