using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace Slagathor
{
    public class ShellCmd
    {
        public void help(List<string> args)
        {
            Console.WriteLine("Here is a list of availible commands:");
            Console.WriteLine("help : Prints this list");
            Console.WriteLine("test : Tests if Shell works");
            Console.WriteLine("cleanup : Cleans up the console");
            Console.WriteLine("milestone : Prints the current milestone");
            Console.WriteLine("beep : Makes the console go beep");
            Console.WriteLine("shutdown : Turns off the computer");
            Console.WriteLine("restart : Turns off then on the computer");
        }
        public void test(List<string> args)
        {
            Console.WriteLine("It works!");
        }
        public void cleanup(List<string> args)
        {
            // clears the console
            Console.Clear();

            // print SLAGATHOR
            Console.WriteLine("   ____ __    ___   _____ ___  _____  __ __ ____   ___ ");
            Console.WriteLine("  / __// /   / _ | / ___// _ |/_  __// // // __ \\ / _ \\");
            Console.WriteLine(" _\\ \\ / /__ / __ |/ (_ // __ | / /  / _  // /_/ // , _/");
            Console.WriteLine("/___//____//_/ |_|\\___//_/ |_|/_/  /_//_/ \\____//_/|_| ");
            Console.WriteLine("Type 'help' to get a list of commands.");
            Console.WriteLine();
        }
        public void milestone(List<string> args)
        {
            Console.WriteLine("Milestone 1.0");
        }
        public void beep(List<string> args)
        {
            Console.WriteLine("Beep");
            Console.Beep();
        }
        public void shutdown(List<string> args)
        {
            Cosmos.System.Power.Shutdown();
        }
        public void restart(List<string> args)
        {
            Cosmos.System.Power.Reboot();
        }
    }
}