using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace Slagathor
{
    public class ShellPromt
    {
        ShellCmd CMD = new ShellCmd();

        public void Forward( string Input )
        {
            List<string> args = ParseArgs(Input);

            if ( Input.StartsWith("help") )
            {
                CMD.help(args);
            }
            else if ( Input.StartsWith("test") )
            {
                CMD.test(args);
            }
            else if ( Input.StartsWith("cleanup") )
            {
                CMD.cleanup(args); 
            }    
            else if ( Input.StartsWith("milestone") )
            {
                CMD.milestone(args);
            }
            else if ( Input.StartsWith("beep") )
            {
                CMD.beep(args);
            }
            else if ( Input.StartsWith("shutdown") )
            {
                CMD.shutdown(args);
            }
            else if ( Input.StartsWith("restart") )
            {
                CMD.restart(args);
            }    
            else
            {
                Console.WriteLine("Error: Not valid command");
            }
        }
        public static List<string> ParseArgs( string Input )
        {
            // credits due at https://github.com/DogOSdev/DogOS/blob/main/DogOS/Shell/Shell.cs

            var args = new List<string>();
            var current_arg = new StringBuilder();
            var in_quotes = false;

            for ( int i = 0; i < Input.Length; i++ )
            {
                if ( Input[i] == '"' )
                {
                    if ( in_quotes )
                    {
                        args.Add( current_arg.ToString() );
                        current_arg = new StringBuilder();
                        in_quotes = false;
                    }
                    else
                    {
                        in_quotes = true;
                    }
                }
                else if ( Input[i] == ' ' )
                {
                    if ( in_quotes )
                    {
                        current_arg.Append( Input[i] );
                    }
                    else if ( current_arg.Length > 0 )
                    {
                        args.Add( current_arg.ToString() );
                        current_arg = new StringBuilder();
                    }
                }
                else
                {
                    current_arg.Append( Input[i] );
                }
            }

            if ( current_arg.Length > 0 ) args.Add( current_arg.ToString() );

            return args;
        }
    }
}