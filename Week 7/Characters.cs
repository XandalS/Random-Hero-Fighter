using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Week_7
{
    class Characters
    {
        protected string Name;
        protected int PowerLevel;
        protected string Weapon;
        protected ConsoleColor Color = ConsoleColor.Red;

        public Characters()
        {

        }

        public Characters(string name, int power, string weapon, ConsoleColor color)
        {
            Name = name;
            PowerLevel = power;
            Weapon = weapon;
            Color = color;
        }

        public void ShowStats()
        {
            ForegroundColor = this.Color;
            WriteLine($"Listing stats for: {this.Name} \nPower Level:{this.PowerLevel} \nWeapon:{this.Weapon}");
            ResetColor();
        }

        public void Fight(Characters O)
        {
            Clear();
            if(this.PowerLevel > O.PowerLevel)
            {
                //Victory
                WriteLine($"After an epic battle, {this.Name} has beaten {O.Name}");
            }else if (this.PowerLevel == O.PowerLevel)
            {
                //Call it a draw
                WriteLine($"After several hours of fighting, {O.Name} and {this.Name} call it a draw.");
            }
            else
            {
                //You Lose
                WriteLine($"{this.Name} fought bravely, but ultimately was bested by {O.Name}");
            }
        }

        virtual public void Talk()
        {
            //talk
        }
    }
}
