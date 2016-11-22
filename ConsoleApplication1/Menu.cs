using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Menu
    {
        public void PrintMenu()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n>> Command lists:");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("===================================================");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("1: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Insert a new pet\n");
            Console.WriteLine("===================================================");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Choose Command: ");
        }
    }
}
