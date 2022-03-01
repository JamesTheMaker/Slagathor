using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace Slagathor
{
    public class Kernel : Sys.Kernel
    {
        ShellPromt Prompt = new ShellPromt();

        protected override void BeforeRun()
        {
            // change console colors
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            // clear the unneccessary bootup info
            Console.Clear();

            // print SLAGATHOR
            Console.WriteLine("   ____ __    ___   _____ ___  _____  __ __ ____   ___ ");
            Console.WriteLine("  / __// /   / _ | / ___// _ |/_  __// // // __ \\ / _ \\");
            Console.WriteLine(" _\\ \\ / /__ / __ |/ (_ // __ | / /  / _  // /_/ // , _/");
            Console.WriteLine("/___//____//_/ |_|\\___//_/ |_|/_/  /_//_/ \\____//_/|_| ");
            Console.WriteLine("Type 'help' to get a list of commands.");
            Console.WriteLine();

            // beep beep
            Console.Beep();
            Console.Beep();
        }

        protected override void Run()
        {
            try
            {
                Console.Write(" > ");
                Prompt.Forward(Console.ReadLine());
            }
            catch(Exception Ex)
            {
                Console.Write("Error: ");
                Console.WriteLine(Ex);
            }
        }
    }
}