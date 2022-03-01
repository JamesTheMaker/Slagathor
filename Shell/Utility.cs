using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace Slagathor
{
    public class Utility
    {
        ShellCmd CMD = new ShellCmd();

        List<string> DummyList = new List<string> { };
    
        public void Crash(string Message)
        {
            Console.Clear();

            Console.WriteLine("Slagathor crashed during runtime.");
            Console.Write("Error Message: ");

            if ( !(Message.Length == 0) )
            { Console.WriteLine(Message); }
            else
            { Console.WriteLine("None provided"); }

            Console.Beep();
            Console.WriteLine();

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            CMD.cleanup(DummyList);
        }
        public static List<string> ParseArgs(string Input)
        {
            // credits due at https://github.com/DogOSdev/DogOS/blob/main/DogOS/Shell/Shell.cs

            var args = new List<string>();
            var current_arg = new StringBuilder();
            var in_quotes = false;

            for (int i = 0; i < Input.Length; i++)
            {
                if (Input[i] == '"')
                {
                    if (in_quotes)
                    {
                        args.Add(current_arg.ToString());
                        current_arg = new StringBuilder();
                        in_quotes = false;
                    }
                    else
                    {
                        in_quotes = true;
                    }
                }
                else if (Input[i] == ' ')
                {
                    if (in_quotes)
                    {
                        current_arg.Append(Input[i]);
                    }
                    else if (current_arg.Length > 0)
                    {
                        args.Add(current_arg.ToString());
                        current_arg = new StringBuilder();
                    }
                }
                else
                {
                    current_arg.Append(Input[i]);
                }
            }

            if (current_arg.Length > 0) args.Add(current_arg.ToString());

            return args;
        }
    }
}