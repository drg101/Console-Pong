using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace Console_Pong
{
    class Game
    {
        public static int score = 0;
        float pPosY, aPosY, bPosX, bPosY;
        float vel, ratio;
        bool bDirX = true, bDirY = true;
        public Game()
        {
            bPosX = Console.WindowHeight / 2;
            bPosY = Console.WindowHeight / 2;
            ratio = (Console.WindowHeight) / 40f;
            vel = 1;
            pPosY = Console.WindowHeight / 2;
            aPosY = Console.WindowHeight / 2;

        }

        public void RunGame()
        {
            while (true)
            {
                Draw.Display((int)bPosX, (int)bPosY, (int)pPosY, (int)aPosY);
                if (bDirX)
                {
                    bPosX += vel;
                }
                else
                {
                    bPosX -= vel;
                }
                if (bDirY)
                {
                    bPosY -= vel;
                }
                else
                {
                    bPosY += vel;
                }
                if (bPosY <= 0 || bPosY >= Console.WindowHeight - 1)
                {
                    bDirY = !bDirY;
                }
                if (KeyListener.up)
                {
                    pPosY -= 2;
                }
                if (KeyListener.down)
                {
                    pPosY += 2;
                }
                KeyListener.up = false;
                KeyListener.down = false;
                if (bDirX && bPosX > Console.WindowHeight) {
                    if (aPosY < bPosY)
                    {
                        aPosY++;
                    }
                    else if (aPosY > bPosY)
                    {
                        aPosY--;
                    }
                }
                if (bPosX >= Console.WindowHeight * 2 - 4 && Math.Abs(bPosY - aPosY) <= 2)
                {
                    Debug.WriteLine("going other way");
                    bDirX = !bDirX;
                    bPosX = Console.WindowHeight * 2 - 4.001f;
                    score++;
                    vel *= 1.05f;
                }
                if (bPosX <= 1 && Math.Abs(bPosY - pPosY) <= 2)
                {
                    bDirX = !bDirX;
                    bPosX = 1.001f;
                    score++;
                    vel *= 1.05f;
                }
                if (bPosX < 0 || bPosX > Console.WindowHeight * 2 - 4)
                {
                    break;
                }
                //Thread.Sleep(1);
            }
            Draw.Display("game over");
        }
    }
}
