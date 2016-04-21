using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            p1.x = 1;
            p1.y = 3;
            p1.sym = '*';
            Draw(p1.x, p1.y, p1.sym);





            /*int x1 = 1;
            int y1 = 3;
            char sym1 = '*';
            Console.SetCursorPosition(x1, y1);
            Console.Write(sym1);*/

 
            Console.ReadLine();
        }

        static void Draw(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
