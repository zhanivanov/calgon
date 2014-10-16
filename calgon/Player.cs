using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calgon
{
    class Player : Entity
    {
        private string[,] playerSymbol = new string[3,3];
        
        private GameObject currPos = new GameObject(1, 1);

        public Player()
            : base(0, 0, 0, 1, 1, 3, 3, ConsoleColor.Green)
        {
            playerSymbol[0, 0] = " ";
            playerSymbol[0, 1] = "/";
            playerSymbol[0, 2] = "/";
            playerSymbol[1, 0] = "o";
            playerSymbol[1, 1] = "|";
            playerSymbol[1, 2] = " ";
            playerSymbol[2, 0] = " ";
            playerSymbol[2, 1] = "\\";
            playerSymbol[2, 2] = "\\";
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
            int countLine = 1;
            for (int i = 0; i < playerSymbol.GetLength(0); i++)
            {
                for (int j = 0; j < playerSymbol.GetLength(1); j++)
                {
                    if ((j == 2 && i == 2) && ((this.PosX % 2 == 0) ^ (this.PosY % 2 == 0)))
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        if ((j == 1 && i == 2) && ((this.PosX % 2 == 0) ^ (this.PosY % 2 == 0)))
                        {
                            Console.Write("/");
                        }
                        else
                        {
                            Console.Write(this.playerSymbol[j, i]);
                        }
                    }
                }
                Console.SetCursorPosition(this.PosX, this.PosY + countLine);
                countLine++;
            }
        }

        private void ClearTrace()
        {
            Console.SetCursorPosition(currPos.PosX, currPos.PosY);
            Console.Write("   ");
            Console.SetCursorPosition(currPos.PosX, currPos.PosY + 1);
            Console.Write("   ");
            Console.SetCursorPosition(currPos.PosX, currPos.PosY + 2);
            Console.Write("   ");
            this.currPos.PosX = this.PosX;
            this.currPos.PosY = this.PosY;
        }
    }
}
