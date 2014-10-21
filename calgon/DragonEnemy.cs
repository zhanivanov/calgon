using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calgon
{
    class DragonEnemy : Enemy
    {
        private string dragonSymbol = "D";

        public DragonEnemy()
            : base(0, 0, 0, 0, 70, 17, 1, 1, "D")
        {
            
        }


    }
}
