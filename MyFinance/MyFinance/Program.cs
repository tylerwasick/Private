using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            MainMenu();
            Console.ReadKey();
        }

        // Print the Main Menu
        private static void MainMenu()
        {
            MenuLine();
            MenuOptions();
            MenuLine();
            Console.WriteLine();
        }

        private static void MenuLine()
        {
            for (int i = 0; i < 119; i++)
            {
                Console.Write("*");
            }
            //Console.WriteLine();
        }

        private static void MenuOptions()
        {
            Console.WriteLine();
            for (int i = 0; i < 22; i++)
            {
                Console.WriteLine("*");
            }
            //Console.WriteLine();
        }

    }

}
