using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance
{
    class Menu
    {
        // Print the Main Menu
        public static void MainMenu()
        {
            MenuLine();
        }

        public static int origWidth = Console.WindowWidth - 1;
        public static int origHeight = Console.WindowHeight;
        public static int margin = 1;
        public static string menuText = "Main Menu";
        public static int stringLen = menuText.Length;

        private static void MenuMargin()
        {
            for (int i = 0; i < margin; i++)
            {
                Console.Write(" ");
            }
        }

        private static void MenuLine()
        {
            int leftLength, rightLength, diffLength;
            diffLength = origWidth - stringLen;

            if (diffLength % 2 == 0)
            {
                leftLength = (diffLength / 2) - margin;
                rightLength = (diffLength / 2) - margin;
            }
            else
                leftLength = (diffLength / 2) + 1 - margin;
            rightLength = (diffLength / 2) - margin;

            for (int i = 0; i < leftLength; i++)
            {
                Console.Write("#");
            }

            MenuMargin();
            Console.Write(menuText);
            MenuMargin();

            for (int i = 0; i < rightLength; i++)
            {
                Console.Write("#");
            }

            Console.WriteLine();
        }
    }
}
