using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineDrawer
{
    class Program
    {
        static void Main(string[] args)
        {
            int width, height;

            int x0, y0, x1, y1;

            do
            {
                Console.Write("Add meg a 'vászon' szélességét [30, 200] intervallumban: ");
            } while (!int.TryParse(Console.ReadLine(), out width) || width < 30 || width > 200);

            do
            {
                Console.Write("Add meg a 'vászon' magasságát [30, 200] intervallumban: ");
            } while (!int.TryParse(Console.ReadLine(), out height) || height < 30 || height > 200);

            do
            {
                Console.Write($"Add meg a kezdőpont x koordinátáját [0, {width}] intervallumban: ");
            } while (!int.TryParse(Console.ReadLine(), out x0) || x0 < 0 || x0 > width);

            do
            {
                Console.Write($"Add meg a kezdőpont y koordinátáját [0, {height}] intervallumban: ");
            } while (!int.TryParse(Console.ReadLine(), out y0) || y0 < 0 || y0 > height);

            do
            {
                Console.Write($"Add meg a végpont x koordinátáját [0, {width}] intervallumban: ");
            } while (!int.TryParse(Console.ReadLine(), out x1) || x1 < 0 || x1 > width);


            do
            {
                Console.Write($"Add meg a végpont y koordinátáját [0, {height}] intervallumban: ");
            } while (!int.TryParse(Console.ReadLine(), out y1) || y1 < 0 || y1 > height);


            char symbol;
            do
            { 
                Console.Write("Adj meg egy szimbólumot, amivel kirajzolhatom a szakaszt (Pl.: #, ?, X, %, stb.): ");
            } while (!char.TryParse(Console.ReadLine(), out symbol));

            Console.WriteLine("Koordináták kiíratása:");
            Console.WriteLine();

            Display display = new Display(
                new MidPointLineDrawingStrategy(),
                width, height, 
                x0, y0, x1, y1, 
                symbol
            );

            foreach (Symbol item in display.SymbolCoordinates)
            {
                Console.WriteLine($"{item.PositionX} {item.PositionY}");
            }
            Console.WriteLine();

            Console.WriteLine("Vonal megjelenítése:");
            Console.WriteLine(display);

            Console.ReadLine();

            
        }
    }
}
