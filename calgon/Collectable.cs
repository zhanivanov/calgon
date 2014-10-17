using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calgon
{
    abstract class Collectable : GameObject
    {
        public static string[] collectableSymbolsArr = { "@", "$", "#", "*" };
        private string collectableSymbol;
        private ConsoleColor color;

        public Collectable(int posX, int posY, string collectableSymbol, ConsoleColor color) : base(posX, posY)
        {
            this.CollectableSymbol = collectableSymbol;
            this.Color = color;
        }

        public string CollectableSymbol { get; set; }

        public ConsoleColor Color { get; set; }

        public void drawCollectable()
        {
            GameField.matrix[this.PosY, this.PosX] = this.CollectableSymbol;
            Utilities.PrintStringOnPositon(this.PosX, this.PosY, this.CollectableSymbol, this.Color);
        }

        public abstract Collectable[] GenerateCollectables(int count);
    }
}
