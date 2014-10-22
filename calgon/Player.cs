using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calgon
{
    class Player : Entity
    {
        private string[,] playerSymbol = new string[3, 3];

        private GameObject currPos = new GameObject(1, 1);
        public static int bombs = 0;

        public Player()
            : base(0, 0, 0, 0,1, 1, 3, 3, ConsoleColor.Green)
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
                    string direction = "left";
                    if (CollisionCheck(this.PosX, this.PosY, this.SizeX, this.SizeY, direction).Length == 0)
                    {
                        this.PosX -= 1;
                        ClearTrace();
                    }
                    else
                    {
                        if (Collectable.CheckSymbolCollision(this, direction))
                        {
                            Collectable.CheckSymbolCollision(this, direction);
                            this.PosX -= 1;
                            ClearTrace();
                        }
                        else
                        {
                            Utilities.PrintStringOnPositon(143, 2, "<", ConsoleColor.Red);
                        }
                    }
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    string direction = "right";
                    if (CollisionCheck(this.PosX, this.PosY, this.SizeX, this.SizeY, direction).Length == 0)
                    {
                        this.PosX += 1;
                        ClearTrace();
                    }
                    else
                    {
                        if (Collectable.CheckSymbolCollision(this, direction))
                        {
                            Collectable.CheckSymbolCollision(this, direction);
                            this.PosX += 1;
                            ClearTrace();
                        }
                        else
                        {
                            Utilities.PrintStringOnPositon(145, 2, ">", ConsoleColor.Red);
                        }
                    }
                }
                else if (pressedKey.Key == ConsoleKey.UpArrow)
                {
                    string direction = "up";
                    if (CollisionCheck(this.PosX, this.PosY, this.SizeX, this.SizeY, direction).Length == 0)
                    {
                        this.PosY -= 1;
                        ClearTrace();
                    }
                    else
                    {
                        if (Collectable.CheckSymbolCollision(this, direction))
                        {
                            Collectable.CheckSymbolCollision(this, direction);
                            this.PosY -= 1;
                            ClearTrace();
                        }
                        else
                        {
                            Utilities.PrintStringOnPositon(144, 1, "^", ConsoleColor.Red);
                        }
                    }
                }
                else if (pressedKey.Key == ConsoleKey.DownArrow)
                {
                    string direction = "down";
                    if (CollisionCheck(this.PosX, this.PosY, this.SizeX, this.SizeY, direction).Length == 0)
                    {
                        this.PosY += 1;
                        ClearTrace();
                    }
                    else
                    {
                        if (Collectable.CheckSymbolCollision(this, direction))
                        {
                            Collectable.CheckSymbolCollision(this, direction);
                            this.PosY += 1;
                            ClearTrace();
                        }
                        else
                        {
                            Utilities.PrintStringOnPositon(144, 3, "v", ConsoleColor.Red);
                        }
                    }
                }
                DrawPlayer();
            }
        }

        public void DrawPlayer()
        {
            Console.SetCursorPosition(this.PosX, this.PosY);
            Console.ForegroundColor = Color;
            int countLine = 1;
            for (int i = 0; i < playerSymbol.GetLength(0); i++)
            {
                for (int j = 0; j < playerSymbol.GetLength(1); j++)
                {
                    if ((j == 2 && i == 2) && ((this.PosX % 2 == 0) ^ (this.PosY % 2 == 0)))
                    {
                        Console.Write(" ");
                        GameField.matrix[this.PosY + i, this.PosX + j] = "p";
                    }
                    else
                    {
                        if ((j == 1 && i == 2) && ((this.PosX % 2 == 0) ^ (this.PosY % 2 == 0)))
                        {
                            Console.Write("/");
                            GameField.matrix[this.PosY + i, this.PosX + j] = "p";
                        }
                        else
                        {
                            Console.Write(this.playerSymbol[j, i]);
                            GameField.matrix[this.PosY + i, this.PosX + j] = "p";
                        }
                    }
                }
                Console.SetCursorPosition(this.PosX, this.PosY + countLine);
                countLine++;
            }
        }

        public void ChekForEnemy()
        {
            if (GameField.matrix[this.PosY - 1, this.PosX - 1] == "D" ||
                GameField.matrix[this.PosY, this.PosX - 1] == "D" ||
                GameField.matrix[this.PosY + 1, this.PosX - 1] == "D" ||
                GameField.matrix[this.PosY + 2, this.PosX - 1] == "D" ||
                GameField.matrix[this.PosY + 3, this.PosX - 1] == "D" ||
                GameField.matrix[this.PosY - 1, this.PosX] == "D" ||
                GameField.matrix[this.PosY, this.PosX] == "D" ||
                GameField.matrix[this.PosY + 1, this.PosX] == "D" ||
                GameField.matrix[this.PosY + 2, this.PosX] == "D" ||
                GameField.matrix[this.PosY + 3, this.PosX] == "D" ||
                GameField.matrix[this.PosY - 1, this.PosX + 1] == "D" ||
                GameField.matrix[this.PosY, this.PosX + 1] == "D" ||
                GameField.matrix[this.PosY + 1, this.PosX + 1] == "D" ||
                GameField.matrix[this.PosY + 2, this.PosX + 1] == "D" ||
                GameField.matrix[this.PosY + 3, this.PosX + 1] == "D" ||
                GameField.matrix[this.PosY - 1, this.PosX + 2] == "D" ||
                GameField.matrix[this.PosY, this.PosX + 2] == "D" ||
                GameField.matrix[this.PosY + 1, this.PosX + 2] == "D" ||
                GameField.matrix[this.PosY + 2, this.PosX + 2] == "D" ||
                GameField.matrix[this.PosY + 3, this.PosX + 2] == "D" ||
                GameField.matrix[this.PosY - 1, this.PosX + 3] == "D" ||
                GameField.matrix[this.PosY, this.PosX + 3] == "D" ||
                GameField.matrix[this.PosY + 1, this.PosX + 3] == "D" ||
                GameField.matrix[this.PosY + 2, this.PosX + 3] == "D" ||
                GameField.matrix[this.PosY + 3, this.PosX + 3] == "D")
            {
                Player.Health -= 1;
                SideInfo.PrintInfo();
            }

        }
        private void ClearTrace()
        {
            Console.SetCursorPosition(currPos.PosX, currPos.PosY);
            GameField.matrix[currPos.PosY, currPos.PosX] = " ";
            GameField.matrix[currPos.PosY, currPos.PosX + 1] = " ";
            GameField.matrix[currPos.PosY, currPos.PosX + 2] = " ";
            Console.Write("   ");
            Console.SetCursorPosition(currPos.PosX, currPos.PosY + 1);
            GameField.matrix[currPos.PosY + 1, currPos.PosX] = " ";
            GameField.matrix[currPos.PosY + 1, currPos.PosX + 1] = " ";
            GameField.matrix[currPos.PosY + 1, currPos.PosX + 2] = " ";
            Console.Write("   ");
            Console.SetCursorPosition(currPos.PosX, currPos.PosY + 2);
            GameField.matrix[currPos.PosY + 2, currPos.PosX] = " ";
            GameField.matrix[currPos.PosY + 2, currPos.PosX + 1] = " ";
            GameField.matrix[currPos.PosY + 2, currPos.PosX + 2] = " ";
            Console.Write("   ");
            this.currPos.PosX = this.PosX;
            this.currPos.PosY = this.PosY;
        }
    }
}
