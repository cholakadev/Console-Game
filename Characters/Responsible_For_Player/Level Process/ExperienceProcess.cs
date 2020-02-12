namespace Game.Characters
{
    using System;

    public class ExperienceProcess
    {
        private const int ExperienceToLose = 10;

        public void EarnExperience(Player player)
        {
            int exp = 0;

            if (player.Level < 3)
            {
                exp = 60;
                player.Experience += exp;
                Console.WriteLine($"{exp}% experience earned!");
            }

            else if (player.Level >= 3 && player.Level < 6)
            {
                exp = 30;
                player.Experience += exp;
                Console.WriteLine($"{exp}% experience earned!");
            }

            else if (player.Level >= 6)
            {
                exp = 15;
                player.Experience += exp;
                Console.WriteLine($"{exp}% experience earned!");
            }

            LevelIncrease levelProcess = new LevelIncrease();
            levelProcess.LevelUp(player);
        }

        public void LoseExperience(Player player)
        {
            if (player.Experience <= 10)
            {
                Console.WriteLine($"Your experience is 0%. Try harder!");
                player.Experience = 0;
            }

            else if (player.Experience > 10)
            {
                Console.WriteLine($"You lost {ExperienceToLose}% experience!");
                player.Experience -= ExperienceToLose;
            }
        }
    }
}
