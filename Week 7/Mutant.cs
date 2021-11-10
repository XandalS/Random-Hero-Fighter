using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Week_7
{
    class Mutant : Characters
    {
        private string MutantAbility;

        public Mutant(string name, int power, string weapon, ConsoleColor color, string m) : base(name, power, weapon, color)
        {
            MutantAbility = m;
        }

        public override void Talk()
        {
            ForegroundColor = this.Color;
            WriteLine($"Hi, name is {this.Name} and my mutant ability is {this.MutantAbility}.");
            ResetColor();
        }
    }
}
