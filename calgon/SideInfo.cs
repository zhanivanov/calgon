using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calgon
{
    class SideInfo
    {
        public static void PrintInfo()
        {
            Utilities.PrintStringOnPositon(155, 10, "Health: " + Entity.Health, ConsoleColor.Yellow);
            Utilities.PrintStringOnPositon(155, 12, "Experience: " + Entity.Exp, ConsoleColor.Yellow);
            Utilities.PrintStringOnPositon(155, 14, "Level: " + Entity.Level, ConsoleColor.Yellow);
            Utilities.PrintStringOnPositon(155, 16, "Points: " + Entity.Points, ConsoleColor.Yellow);
            Utilities.PrintStringOnPositon(155, 18, "Bombs: " + Player.bombs, ConsoleColor.Yellow);

        }
    }
}
