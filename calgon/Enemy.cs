using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calgon
{
    abstract class Enemy : NPC
    {
        public Enemy(int exp, int level, int health, int posX, int posY, int sizeX, int sizeY)
            : base(exp, level, health, posX, posY, sizeX, sizeY)
        {

        }
        public abstract void EntityMove();
        public bool EntityColision(int posX, int posY)
        {
            if (GameField.matrix[posX, posY] == "█")
            
            {
                return false;
            }
            return true;
        }
    }
}
