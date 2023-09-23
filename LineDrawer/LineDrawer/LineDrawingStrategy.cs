using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineDrawer
{
    interface LineDrawingStrategy
    {
        List<Symbol> Calculate(int x0, int y0, int x1, int y1, char drawingSymbol);
    }
}
