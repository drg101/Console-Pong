using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Pong
{
    class KeyListener
    {
        public static bool up = false, down = false;
        public static void keyPresses()
        {
            do
            {
                ConsoleKeyInfo keyinfo = Console.ReadKey();
                if(keyinfo.Key == ConsoleKey.UpArrow)
                {
                    up = true;
                }
                if (keyinfo.Key == ConsoleKey.DownArrow)
                {
                    down = true;
                }
            }
            while (true);
        }
    }
}
