using System;
using System.Collections.Generic;
using System.Text;

namespace TheHeist
{
    class Bank
    {
        public int DifficultyLevel { get; set; }
        int LuckValue { get; set; }

        public Bank(int difficulty)
        {
            DifficultyLevel = difficulty;

        }
        public void modifyingLuck() {
            Random rnd = new Random();
            LuckValue = rnd.Next(-10, 10);
        }

    }
}
