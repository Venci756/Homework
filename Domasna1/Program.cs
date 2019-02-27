using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domasna1
{
    class Program
    {
        static void Main()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("      *      ");
            Console.WriteLine("     ***     ");
            Console.WriteLine("    *****    ");
            Console.WriteLine("   *******   ");
            Console.WriteLine("  *********  ");
            Console.WriteLine(" *********** ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("     ***     ");
            Console.WriteLine("     ***     ");
            Console.ResetColor();
        }
    }
}
