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

        public int[] CollisionCheck(int posX, int posY, int sizeX, int sizeY, string direction)
        {
            switch (direction)
            {
                case "left":
                    if (GameField.matrix[this.PosY, this.PosX - 1] != " ")
                    {
                        return new int[2] { this.PosY, this.PosX - 1 };
                    }
                    else if (GameField.matrix[this.PosY + 1, this.PosX - 1] != " ")
                    {
                        return new int[2] { this.PosY + 1, this.PosX - 1 };
                    }
                    else if (GameField.matrix[this.PosY + 2, this.PosX - 1] != " ")
                    {
                        return new int[2] { this.PosY + 2, this.PosX - 1 };
                    }
                    else
                    {
                        return new int[0];
                    }
                case "right":
                    if (GameField.matrix[this.PosY, this.PosX + this.SizeX] != " ")
                    {
                        return new int[2] { this.PosY, this.PosX + this.SizeX };
                    }
                    else if (GameField.matrix[this.PosY + 1, this.PosX + this.SizeX] != " ")
                    {
                        return new int[2] { this.PosY + 1, this.PosX + this.SizeX };
                    }
                    else if (GameField.matrix[this.PosY + 2, this.PosX + this.SizeX] != " ")
                    {
                        return new int[2] { this.PosY + 2, this.PosX + this.SizeX };
                    }
                    else
                    {
                        return new int[0];
                    }
                case "up":
                    if (GameField.matrix[this.PosY - 1, this.PosX] != " ")
                    {
                        return new int[2] { this.PosY - 1, this.PosX };
                    }
                    else if (GameField.matrix[this.PosY - 1, this.PosX + 1] != " ")
                    {
                        return new int[2] { this.PosY - 1, this.PosX + 1 };
                    }
                    else if (GameField.matrix[this.PosY - 1, this.PosX + 2] != " ")
                    {
                        return new int[2] { this.PosY - 1, this.PosX + 2 };
                    }
                    else
                    {
                        return new int[0];
                    }
                case "down":
                    if (GameField.matrix[this.PosY + this.SizeY, this.PosX] != " ")
                    {
                        return new int[2] { this.PosY + this.SizeY, this.PosX };
                    }
                    else if (GameField.matrix[this.PosY + this.SizeY, this.PosX + 1] != " ")
                    {
                        return new int[2] { this.PosY + this.SizeY, this.PosX + 1 };
                    }
                    else if (GameField.matrix[this.PosY + this.SizeY, this.PosX + 2] != " ")
                    {
                        return new int[2] { this.PosY + this.SizeY, this.PosX + 2 };
                    }
                    else
                    {
                        return new int[0];
                    }
            }

            return new int[0];
        }
    }
}
