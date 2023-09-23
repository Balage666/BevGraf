using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineDrawer
{
    class DDALineDrawingStrategy : LineDrawingStrategy
    {
        private static int Round(float n)
        {
            if (n - (int)n < 0.5)
                return (int)n;
            return (int)(n + 1);
        }
        public List<Symbol> Calculate(int x0, int y0, int x1, int y1, char drawingSymbol)
        {
            List<Symbol> symbols = new List<Symbol>();

            int dx = x1 - x0;
            int dy = y1 - y0;

            int step;

            if (Math.Abs(dx) > Math.Abs(dy))
            {
                step = Math.Abs(dx);
            }
            else
            {
                step = Math.Abs(dy);
            }

            float xIncrement = (float)dx / step;
            float yIncrement = (float)dy / step;

            float x = x0;
            float y = y0;

            for (int i = 0; i <= step; i++)
            {

                symbols.Add(
                    new Symbol(Round(x), Round(y), drawingSymbol)
                );

                x += xIncrement;
                y += yIncrement;
            }

            return symbols;
        }
    }
}
