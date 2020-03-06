using System;

namespace domasna01
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hellouu Driver!");
            Console.WriteLine();
            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("  STOP   ");
            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  READY  ");
            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("  GO!    ");

            Console.ResetColor();
            Console.ReadLine();
            Console.WriteLine("Baj baaaj Driver!");
            Console.ReadLine();
        }
    }
}
