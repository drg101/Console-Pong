using System;
using System.Threading;

namespace Console_Pong
{
    class Program
    {
        static int width, height;
        static void Main(string[] args)
        {
            width = Console.WindowWidth;
            height = Console.WindowHeight;
            Console.WriteLine(width + height);
            
            Draw.Display("press enter to start");
            Thread thread2 = new Thread(KeyPressListener);
            thread2.Start();

            Thread thread3 = new Thread(KeyListener.keyPresses);
            thread3.Start();
        }

        static void KeyPressListener(){
            while (!Console.ReadKey().Key.Equals(ConsoleKey.Enter)){}
            Game main = new Game();
            main.RunGame();
        }

    }
}
