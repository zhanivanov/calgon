using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calgon
{
    class GameObject
    {
        private int posX;
        private int posY;
        private int sizeX;
        private int sizeY;

        public GameObject(int posX, int posY)
        {
            this.PosX = posX;
            this.PosY = posY;
        }

        public GameObject(int posX, int posY, int sizeX, int sizeY)
        {
            this.PosX = posX;
            this.PosY = posY;
            this.SizeX = sizeX;
            this.SizeY = sizeY;
        }

        public int PosX { get; set; }
        public int PosY { get; set; }
        public int SizeX { get; set; }
        public int SizeY { get; set; }

        public void Draw()
        {

        }
    }
}
