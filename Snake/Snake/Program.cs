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
         

            int x2 = 4;
            int y2 = 5;
            char sym2 = '#';
            Console.SetCursorPosition(x2, y2);
            Console.Write(sym2);
            Console.ReadLine();
        }

        static void Draw(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
