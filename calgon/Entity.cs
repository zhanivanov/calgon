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
            this.Exp = exp;
            this.Level = level;
            this.Health = health;
            this.Color = color;
        }

        public int Exp { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }
        public ConsoleColor Color { get; set; }

        public void Move()
        {

        }

        public bool CollisionCheck(int posX, int posY, int sizeX, int sizeY, string direction)
        {
            switch (direction)
            {
                case "left":
                    if (GameField.matrix[this.PosY, this.PosX - this.SizeX] != "█")
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                case "right":
                    if (GameField.matrix[this.PosY, this.PosX + this.SizeX] != "█")
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                case "up":
                    if (GameField.matrix[this.PosY - this.SizeY, this.PosX] != "█")
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                case "down":
                    if (GameField.matrix[this.PosY + this.SizeY, this.PosX] != "█")
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
            }
            return true;
        }
    }
}
