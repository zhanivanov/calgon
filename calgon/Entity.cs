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

        public Entity(int exp, int level, int health, int posX = 0, int posY = 0, int sizeX = 1, int sizeY = 1) 
            : base(posX, posY, sizeX, sizeY)
        {
            this.Exp = exp;
            this.Level = level;
            this.Health = health;
        }

        public int Exp { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }

        public void Move()
        {

        }

        //public abstract void Collision();
    }
}
