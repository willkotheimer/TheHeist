using System;
using System.Collections.Generic;
using System.Text;

namespace TheHeist
{
    class TeamMember
    {
        public double SkillLevel;
        public double CourageFactor;
        public string Name;
        public TeamMember(string name, double skillLevel, double courageFactor)
        {
            Name = name;
            SkillLevel = skillLevel;
            CourageFactor = courageFactor;

        }

        public void printInfo()
        {
            Console.WriteLine($"{Name} has a skill level of {SkillLevel} and a Courage Factor of {CourageFactor}");

        }

    }
}
