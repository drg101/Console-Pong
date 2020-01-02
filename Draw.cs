using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Console_Pong
{
    public class Draw
    {
        public static void Display(String textToDisplay)
        {
            Console.Clear();
            for (int i = 0; i < Console.WindowHeight / 2; i++)
            {
                Console.WriteLine(".");
            }
            Console.WriteLine(textToDisplay);
            for (int i = 0; i < Console.WindowHeight / 2 - 1; i++)
            {
                Console.WriteLine(".");
            }
        }

        static String lineBuilder(int bPosX, int bPosY, int pPosY, int aPosY, int i)
        {
            String line = " ";
            int spacing = Console.WindowWidth / (Console.WindowHeight * 2);
            if (i >= pPosY - 2 && i <= pPosY + 2)
            {
                if (i == pPosY)
                {
                    line += Game.score;
                }
                else {
                    line += "|";
                }
            }
            else
            {
                line += " ";
            }
            if (i == bPosY)
            {
                for (int j = 0; j < spacing * bPosX; j++)
                {
                    line += " ";
                }
                line += "O";
                for (int j = 0; j < spacing * (Console.WindowHeight - bPosX - 2) * 2 + (spacing * bPosX); j++)
                {
                    line += " ";
                }
            }
            else
            {
                for (int j = 0; j < spacing * (Console.WindowHeight - 2) * 2; j++)
                {
                    line += " ";
                }
                line += " ";
            }
            if (i >= aPosY - 2 && i <= aPosY + 2)
            {
                line += "|";
            }
            else
            {
                line += " ";
            }
            return line;
        }

        public static void Display(int bPosX, int bPosY, int pPosY, int aPosY)
        {
            String lineMain = "";
            for (int i = 0; i < Console.WindowHeight - 1; i++)
            {
                lineMain += lineBuilder(bPosX, bPosY, pPosY, aPosY, i) + "\n";
            }
            lineMain += lineBuilder(bPosX, bPosY, pPosY, aPosY, Console.WindowHeight - 1);
            //Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.Write(lineMain);
        }
    }
}
