using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineDrawer
{
    class DDA
    {
        // function for rounding off the pixels
        private static int Round(float n)
        {
            if (n - (int)n < 0.5)
                return (int)n;
            return (int)(n + 1);
        }

        // Function for line generation
        public static List<Symbol> Draw(int x0, int y0, int x1, int y1, char symbolChar)
        {

            List<Symbol> symbols = new List<Symbol>();

            // Calculate dx and dy
            int dx = x1 - x0;
            int dy = y1 - y0;

            int step;

            // If dx > dy we will take step as dx
            // else we will take step as dy to draw the complete
            // line
            if (Math.Abs(dx) > Math.Abs(dy))
                step = Math.Abs(dx);
            else
                step = Math.Abs(dy);

            // Calculate x-increment and y-increment for each
            // step
            float x_incr = (float)dx / step;
            float y_incr = (float)dy / step;

            // Take the initial points as x and y
            float x = x0;
            float y = y0;

            for (int i = 0; i <= step; i++)
            {

                // putpixel(round(x), round(y), WHITE);
                //Console.WriteLine(Round(x) + " " + Round(y));
                symbols.Add(
                    new Symbol(Round(x), Round(y), symbolChar)
                );

                x += x_incr;
                y += y_incr;
                // delay(10);
            }

            return symbols;
        }
    }
}
