using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calgon
{
    class HealthCollectable : Collectable
    {
        private int bonusHealth = 10;

        public HealthCollectable(int posX, int posY) : base(posX, posY, "@", ConsoleColor.Blue)
        {

        }
    }
}
