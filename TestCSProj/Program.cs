using System;

// A test project.

namespace TestCSProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello. Welcome to the program. Press a key to continue.");
            Console.ReadKey();
            Console.WriteLine("Would you like to crash the program, or close it gracefully?");
            Console.WriteLine("Type \"crash\" to crash, type \"close\" to close gracefully.");

            string txt = Console.ReadLine();
            switch (txt)
            {
                case "crash": throw new Exception("CRASH!!! >:)");
                case "close": Environment.Exit(0); break;
                default: throw new Exception("You didn't answer correctly, so CRASH!!! >:)");
            }
        }
    }
}
