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
        private ConsoleColor color;

        public Entity(int exp, int level, int health, int posX = 0, int posY = 0, int sizeX = 1, int sizeY = 1, ConsoleColor color = ConsoleColor.Blue)
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
                        return true;
                    }
                    else if (GameField.matrix[this.PosY + 1, this.PosX - 1] != " ")
                    {
                        return true;
                    }
                    else if (GameField.matrix[this.PosY + 2, this.PosX - 1] != " ")
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case "right":
                    if (GameField.matrix[this.PosY, this.PosX + this.SizeX] != " ")
                    {
                        return true;
                    }
                    else if (GameField.matrix[this.PosY + 1, this.PosX + this.SizeX] != " ")
                    {
                        return true;
                    }
                    else if (GameField.matrix[this.PosY + 2, this.PosX + this.SizeX] != " ")
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case "up":
                    if (GameField.matrix[this.PosY - 1, this.PosX] != " ")
                    {
                        return true;
                    }
                    else if (GameField.matrix[this.PosY - 1, this.PosX + 1] != " ")
                    {
                        return true;
                    }
                    else if (GameField.matrix[this.PosY - 1, this.PosX + 2] != " ")
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case "down":

                    if (GameField.matrix[this.PosY + this.SizeY, this.PosX] != " ")
                    {
                        return true;
                    }
                    else if (GameField.matrix[this.PosY + this.SizeY, this.PosX + 1] != " ")
                    {
                        return true;
                    }
                    else if (GameField.matrix[this.PosY + this.SizeY, this.PosX + 2] != " ")
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }


            }
            return true;
        }
    }
}
