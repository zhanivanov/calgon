using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calgon
{
    class SideInfo
    {
        private static int counter;
        private static int step;
        private static int health;
        private static string healthBar;
        private static ConsoleColor healthColor;

        static SideInfo()
        {
            SideInfo.counter = 10;
            SideInfo.step = 50;
            SideInfo.health = 1000;
            SideInfo.healthBar = new string('█', counter);
            SideInfo.healthColor = ConsoleColor.DarkGreen;
            SideInfo.PrintInfoStrings();
        }

        public static void PrintInfo()
        {
            SideInfo.ClearBar();
            SideInfo.health = Entity.Health;
            SideInfo.counter = Entity.Health / 100;
            if (SideInfo.counter > 10)
            {
                SideInfo.counter = 10;
            }
            if (SideInfo.counter < 1)
            {
                SideInfo.counter = 1;
            }
            SideInfo.healthBar = new string('█', counter);
            if (SideInfo.counter < 10)
            {
                SideInfo.healthColor = ConsoleColor.DarkGreen;
            }
            if (SideInfo.counter < 8)
            {
                SideInfo.healthColor = ConsoleColor.Green;
            }
            if (SideInfo.counter < 6)
            {
                SideInfo.healthColor = ConsoleColor.Yellow;
            }
            if (SideInfo.counter < 4)
            {
                    SideInfo.healthColor = ConsoleColor.Red;
            }
            if (SideInfo.counter < 2)
            {
                SideInfo.healthColor = ConsoleColor.DarkRed;
            }
            Utilities.PrintStringOnPositon(158, 6, healthBar, healthColor);
            Utilities.PrintStringOnPositon(163, 7, Entity.Exp.ToString(), ConsoleColor.Yellow);
            Utilities.PrintStringOnPositon(163, 8, Entity.Level.ToString(), ConsoleColor.Yellow);
            Utilities.PrintStringOnPositon(163, 9, Entity.Points.ToString(), ConsoleColor.Yellow);
            Utilities.PrintStringOnPositon(163, 10, Player.bombs.ToString(), ConsoleColor.Yellow);

        }

        public static void PrintInfoStrings()
        {
            Utilities.PrintStringOnPositon(150, 6, "Health: ", ConsoleColor.White);
            Utilities.PrintStringOnPositon(150, 7, "Experience: ", ConsoleColor.White);
            Utilities.PrintStringOnPositon(150, 8, "Level: ", ConsoleColor.White);
            Utilities.PrintStringOnPositon(150, 9, "Points: ", ConsoleColor.White);
            Utilities.PrintStringOnPositon(150, 10, "Bombs: ", ConsoleColor.White);
        }

        public static void ClearBar()
        {
            Utilities.PrintStringOnPositon(158, 6, new string(' ', 10), healthColor);
        }
    }
}
