using System;
using System.Collections.Generic;

namespace TheHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");

            Console.WriteLine("Please enter the difficulty level of the bank (1-100):");
            int BankDifficultyLevel = int.Parse(Console.ReadLine());
            Bank myBank = new Bank(BankDifficultyLevel);

            bool keepRecruiting = true;
            Team team = new Team();

            while(keepRecruiting)
        {
                Console.WriteLine("Enter your team member's name:");
                var name = Console.ReadLine();
                if(name != "")
                {
                    Console.WriteLine("Enter the team members skill level, a number between 0.0 and 2.0:");
                    var skillLevel = Double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the team members courage factor:");
                    var courageFactor = Double.Parse(Console.ReadLine());

                    var teamMember = new TeamMember(name, skillLevel, courageFactor);

                    team.addTeamMember(teamMember);

                    continue;
                }
                else
                {
                    keepRecruiting = false;
                }

                Console.WriteLine($"There are {team.getCount()} members in the team.");

                Console.WriteLine("Enter the number of times to run the similation");

                int numberOfTimes = int.Parse(Console.ReadLine());

                for(var number = 0; number <= numberOfTimes; number++)
                {

                    myBank.modifyingLuck();
                    double teamSkillLevel = 0;
                    foreach (var member in team.group)
                    {
                        teamSkillLevel += member.SkillLevel;
                    }

                    Console.WriteLine($"Teams Combined Skill Level = {teamSkillLevel}");
                    Console.WriteLine($"Banks Difficulty Level = {myBank.DifficultyLevel}");
                    if (teamSkillLevel >= BankDifficultyLevel)
                    {
                        Console.WriteLine($"Success");
                    }
                    else
                    {
                        Console.WriteLine($"Failure");
                    }

                }

            }

        }
    }
}
