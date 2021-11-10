using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Week_7
{
    class Enhanced : Characters
    {
        private string Enchancement;

        public Enhanced(string name, int power, string weapon, ConsoleColor color,string e) : base(name, power, weapon, color)
        {
            Enchancement = e;
        }

        public override void Talk()
        {
            ForegroundColor = this.Color;
            WriteLine($"Hi, my name is {this.Name} and I am Enhanced with {Enchancement}.");
            ResetColor();
        }
    }
}
