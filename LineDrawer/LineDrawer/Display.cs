using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineDrawer
{
    class Display
    {
        char[,] displayBoard;
        public char[,] DisplayBoard { get => displayBoard; set => displayBoard = value; }

        LineDrawingStrategy lineDrawingStrategy;
        internal LineDrawingStrategy LineDrawingStrategy { get => lineDrawingStrategy; set => lineDrawingStrategy = value; }

        List<Symbol> symbolCoordinates;
        internal List<Symbol> SymbolCoordinates { get => symbolCoordinates; set => symbolCoordinates = value; }

        public Display(LineDrawingStrategy lineDrawingStrategy, int width, int height, int x0, int y0, int x1, int y1, char drawingSymbol)
        {
            this.DisplayBoard = new char[width + 1, height + 1];

            //foreach (Symbol symbol in symbols)
            //{
            //    this.DisplayBoard[symbol.PositionX, symbol.PositionY] = symbol.SymbolChar;
            //}

            this.LineDrawingStrategy = lineDrawingStrategy;

            this.SymbolCoordinates = this.LineDrawingStrategy.Calculate(x0, y0, x1, y1, drawingSymbol);

            foreach (Symbol symbol in this.SymbolCoordinates)
            {
                this.DisplayBoard[symbol.PositionX, symbol.PositionY] = symbol.SymbolChar;
            }

        }

        public Display(char[,] board)
        {
            this.DisplayBoard = board;
        }

        public override string ToString()
        {
            string value = string.Empty;

            for (int i = 1; i <= this.DisplayBoard.GetLength(1); i++)
            {
                value += "-";
            }

            value += "\n";

            for (int row = 0; row < this.DisplayBoard.GetLength(0); row++)
            {
                value += "| ";

                for (int col = 0; col < this.DisplayBoard.GetLength(1) - 1; col++)
                {
                    value += $"{this.DisplayBoard[row, col]}";
                }

                value += $"{this.DisplayBoard[row, this.DisplayBoard.GetLength(1) - 1]} |\n";
            }
            
            for (int i = 1; i <= this.DisplayBoard.GetLength(1); i++)
            {
                value += "-";
            }

            value += "\n";

            return value;
        }
    }
}
