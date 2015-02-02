using Microsoft.Xna.Framework.Graphics;
using RogueSharp.Random;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace ExampleGame
{
    public class Figure
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Texture2D Sprite { get; set; }

        // Roll a 20-sided die and add this value when making an attack
        public int AttackBonus { get; set; }
        // An attack must meet or exceed this value to hit
        public int ArmorClass { get; set; }
        // Roll these dice to determine how much damage was dealt after a hit
        public Dice Damage { get; set; }
        // How many points of damage the figure can withstand before dieing
        public int MaxHealth { get; set; }
        // How many points of damage the figure can withstand before dieing
        public int CurrentHealth { get; set; }
        // The name of the figure, used for attack messages
        public string Name { get; set; }

        public int Level { get; set; }
        public int Experience { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }



        public virtual void LevelUp()
        {

        }

        public virtual void ModifyExperience()
        {
            
        }

        public bool IsLevelUp(Figure figure)
        {
            if (figure.Experience >= figure.Level)
            {
                Debug.WriteLine("{0} reached Level {1}", figure.Name, figure.Level);
                return true;
            }

            return false;
        }
    }
}
