using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineDrawer
{
    class Symbol
    {
        private int positionX;

        public int PositionX
        {
            get { return positionX; }
            set { positionX = value; }
        }

        private int positionY;

        public int PositionY
        {
            get { return positionY; }
            set { positionY = value; }
        }

        private char symbolChar;

        public char SymbolChar
        {
            get { return symbolChar; }
            set { symbolChar = value; }
        }

        public Symbol(int x, int y, char symbolChar)
        {
            this.PositionX = x;
            this.PositionY = y;
            this.SymbolChar = symbolChar;
        }
    }
}
