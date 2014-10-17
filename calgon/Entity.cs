using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calgon
{
    class Entity : GameObject
    {
        private int exp;
        private int level;
        private int health;
        private int points;
        private ConsoleColor color;

        public Entity(int exp, int level, int health,int points, int posX = 0, int posY = 0, int sizeX = 1, int sizeY = 1, ConsoleColor color = ConsoleColor.Blue)
            : base(posX, posY, sizeX, sizeY)
        {
            Exp = exp;
            Level = level;
            Health = health;
            Color = color;
        }

        public static int Exp { get; set; }
        public static int Level { get; set; }
        public static int Health { get; set; }
        public static int Points { get; set; }
        public static ConsoleColor Color { get; set; }

        public void Move()
        {

        }

        public bool CollisionCheck(int posX, int posY, int sizeX, int sizeY, string direction)
        {
            switch (direction)
            {
                case "left":
                    if (GameField.matrix[this.PosY, this.PosX - 1] != " ")
                    {
                        if (CheckSymbolCollision(GameField.matrix[this.PosY, this.PosX - 1]))
                        {
                            Utilities.PrintStringOnPositon(this.PosX, this.PosY, " ");
                            GameField.matrix[this.PosY, this.PosX - 1] = " ";

                            return false;
                        }

                        return true;
                    }
                    else if (GameField.matrix[this.PosY + 1, this.PosX - 1] != " ")
                    {
                        if (CheckSymbolCollision(GameField.matrix[this.PosY + 1, this.PosX - 1]))
                        {
                            Utilities.PrintStringOnPositon(this.PosX, this.PosY, " ");
                            GameField.matrix[this.PosY + 1, this.PosX - 1] = " ";

                            return false;
                        }

                        return true;
                    }
                    else if (GameField.matrix[this.PosY + 2, this.PosX - 1] != " ")
                    {
                        if (CheckSymbolCollision(GameField.matrix[this.PosY + 2, this.PosX - 1]))
                        {
                            Utilities.PrintStringOnPositon(this.PosX, this.PosY, " ");
                            GameField.matrix[this.PosY + 2, this.PosX - 1] = " ";

                            return false;
                        }

                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case "right":
                    if (GameField.matrix[this.PosY, this.PosX + this.SizeX] != " ")
                    {
                        if (CheckSymbolCollision(GameField.matrix[this.PosY, this.PosX + this.SizeX]))
                        {
                            Utilities.PrintStringOnPositon(this.PosX, this.PosY, " ");
                            GameField.matrix[this.PosY, this.PosX + this.SizeX] = " ";

                            return false;
                        }
                        return true;
                    }
                    else if (GameField.matrix[this.PosY + 1, this.PosX + this.SizeX] != " ")
                    {
                        if (CheckSymbolCollision(GameField.matrix[this.PosY + 1, this.PosX + this.SizeX]))
                        {
                            Utilities.PrintStringOnPositon(this.PosX, this.PosY, " ");
                            GameField.matrix[this.PosY + 1, this.PosX + this.SizeX] = " ";

                            return false;
                        }

                        return true;
                    }
                    else if (GameField.matrix[this.PosY + 2, this.PosX + this.SizeX] != " ")
                    {
                        if (CheckSymbolCollision(GameField.matrix[this.PosY + 2, this.PosX + this.SizeX]))
                        {
                            Utilities.PrintStringOnPositon(this.PosX, this.PosY, " ");
                            GameField.matrix[this.PosY + 2, this.PosX + this.SizeX] = " ";

                            return false;
                        }

                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case "up":
                    if (GameField.matrix[this.PosY - 1, this.PosX] != " ")
                    {
                        if (CheckSymbolCollision(GameField.matrix[this.PosY - 1, this.PosX]))
                        {
                            Utilities.PrintStringOnPositon(this.PosX, this.PosY, " ");
                            GameField.matrix[this.PosY + 1, this.PosX + this.SizeX] = " ";

                            return false;
                        }

                        return true;
                    }
                    else if (GameField.matrix[this.PosY - 1, this.PosX + 1] != " ")
                    {
                        if (CheckSymbolCollision(GameField.matrix[this.PosY - 1, this.PosX + 1]))
                        {
                            Utilities.PrintStringOnPositon(this.PosX, this.PosY, " ");
                            GameField.matrix[this.PosY - 1, this.PosX + 1] = " ";

                            return false;
                        }

                        return true;
                    }
                    else if (GameField.matrix[this.PosY - 1, this.PosX + 2] != " ")
                    {
                        if (CheckSymbolCollision(GameField.matrix[this.PosY + 1, this.PosX + this.SizeX]))
                        {
                            Utilities.PrintStringOnPositon(this.PosX, this.PosY, " ");
                            GameField.matrix[this.PosY - 1, this.PosX + 2] = " ";

                            return false;
                        }

                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case "down":
                    if (GameField.matrix[this.PosY + this.SizeY, this.PosX] != " ")
                    {
                        if (CheckSymbolCollision(GameField.matrix[this.PosY + this.SizeY, this.PosX]))
                        {
                            Utilities.PrintStringOnPositon(this.PosX, this.PosY, " ");
                            GameField.matrix[this.PosY + this.SizeY, this.PosX] = " ";

                            return false;
                        }

                        return true;
                    }
                    else if (GameField.matrix[this.PosY + this.SizeY, this.PosX + 1] != " ")
                    {
                        if (CheckSymbolCollision(GameField.matrix[this.PosY + this.SizeY, this.PosX + 1]))
                        {
                            Utilities.PrintStringOnPositon(this.PosX, this.PosY, " ");
                            GameField.matrix[this.PosY + this.SizeY, this.PosX + 1] = " ";

                            return false;
                        }

                        return true;
                    }
                    else if (GameField.matrix[this.PosY + this.SizeY, this.PosX + 2] != " ")
                    {
                        if (CheckSymbolCollision(GameField.matrix[this.PosY + this.SizeY, this.PosX - 2]))
                        {
                            Utilities.PrintStringOnPositon(this.PosX, this.PosY, " ");
                            GameField.matrix[this.PosY + this.SizeY, this.PosX + 2] = " ";

                            return false;
                        }

                        return true;
                    }
                    else
                    {
                        return false;
                    }
            }
            return true;
        }


        private bool CheckSymbolCollision(string collectableSymbol)
        {
            string[] collectableSymbols = Collectable.collectableSymbolsArr;
            bool isContaining = collectableSymbols.Contains(collectableSymbol);
            if (isContaining)
            {
                switch (collectableSymbol)
                {
                    case "@":
                        Player.Health += HealthCollectable.bonusHealth;
                        break;
                    case "$":
                        Player.Exp += ExperienceCollectable.bonusExp;
                        break;
                    case "#":
                        // gun implementation
                        break;
                    case "*":
                        Player.Points += BonusCollectable.bonusPoints;
                        break;
                    default:
                        break;
                }
                SideInfo.PrintInfo();

                return true;
            }

            return false;
        }
    }
}
