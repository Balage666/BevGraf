using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineDrawer
{
    class MidPointLineDrawingStrategy : LineDrawingStrategy
    {
        public List<Symbol> Calculate(
            int x0, int y0, int x1, int y1, 
            char drawingSymbol
        )
        {
            List<Symbol> symbols = new List<Symbol>();

            int dx = x1 - x0;
            int dy = y1 - y0;

            int d = dy - (dx / 2);
            
            int x = x0; 
            int y = y0;

            symbols.Add(
                new Symbol(x, y, drawingSymbol)
            );

            while (x < x1)
            {
                x++;

                if (d < 0)
                {
                    d = d + dy;
                }
                else
                {
                    d += (dy - dx);
                    y++;
                }

                symbols.Add(
                    new Symbol(x, y, drawingSymbol)
                );
                
            }

            return symbols;
        }
    }
}
