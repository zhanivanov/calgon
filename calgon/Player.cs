using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calgon
{
    class Player : Entity
    {
        private string playerSymbol;
        private GameObject currPos = new GameObject(1, 1);

        public Player(string playerSymbol)
            : base(0, 0, 0, 1, 1, 1, 1, ConsoleColor.Blue)
        {
            this.playerSymbol = playerSymbol;
        }

        public void MovePlayer()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                while (Console.KeyAvailable) Console.ReadKey(true);
                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (!CollisionCheck(this.PosX, this.PosY, this.SizeX, this.SizeY, "left"))
                    {
                        this.PosX -= 1;
                        ClearTrace();
                    }
                    else
                    {
                        Utilities.PrintStringOnPositon(60, 5, "Leftward Collision!", ConsoleColor.Red);
                    }
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if (!CollisionCheck(this.PosX, this.PosY, this.SizeX, this.SizeY, "right"))
                    {
                        this.PosX += 1;
                        ClearTrace();
                    }
                    else
                    {
                        Utilities.PrintStringOnPositon(60, 10, "Rightward Collision!", ConsoleColor.Red);
                    }
                }
                else if (pressedKey.Key == ConsoleKey.UpArrow)
                {
                    if (!CollisionCheck(this.PosX, this.PosY, this.SizeX, this.SizeY, "up"))
                    {
                        this.PosY -= 1;
                        ClearTrace();
                    }
                    else
                    {
                        Utilities.PrintStringOnPositon(60, 15, "Upward Collision!", ConsoleColor.Red);
                    }
                }
                else if (pressedKey.Key == ConsoleKey.DownArrow)
                {
                    if (!CollisionCheck(this.PosX, this.PosY, this.SizeX, this.SizeY, "down"))
                    {
                        this.PosY += 1;
                        ClearTrace();
                    }
                    else
                    {
                        Utilities.PrintStringOnPositon(60, 20, "Downward Collision!", ConsoleColor.Red);
                    }
                }
                DrawPlayer();
            }
        }

        public void DrawPlayer()
        {
            Console.SetCursorPosition(this.PosX, this.PosY);
            Console.ForegroundColor = this.Color;
            Console.Write(this.playerSymbol);
        }

        private void ClearTrace()
        {
            Console.SetCursorPosition(currPos.PosX, currPos.PosY);
            Console.Write(" ");
            this.currPos.PosX = this.PosX;
            this.currPos.PosY = this.PosY;
        }
    }
}
