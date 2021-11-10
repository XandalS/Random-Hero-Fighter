using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Week_7
{
    class Match
    {
        private Characters One, Two;
        private List<Characters> characters = new List<Characters>();
        private Random R = new Random();

        public Match()
        {
            One = new Mutant("Wolverine",R.Next(1,20), "Claws", ConsoleColor.Yellow, "Healing Factor");
            Two = new Enhanced("Captain America",R.Next(1,20), "Sheild", ConsoleColor.Blue, "Super Strength");

            characters.Add(One);
            characters.Add(Two);

            StartMatch();
        }

        public void StartMatch()
        {
            foreach(Characters c in characters)
            {
                c.ShowStats();
                c.Talk();
            }
            WriteLine($"\nPress any key to continue...");
            ReadKey(true);

            One.Fight(Two);
            ReadKey(true);
        }
    }
}
