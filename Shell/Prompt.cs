using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace Slagathor
{
    public class ShellPromt
    {
        ShellCmd CMD = new ShellCmd();
        Utility Util = new Utility();

        public void Forward( string Input )
        {
            List<string> args = Utility.ParseArgs(Input);
            if ( args.Count >= 1 )
            {
                args.RemoveAt(0);
            }

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
            else if ( Input.StartsWith("crash") )
            {
                Util.Crash(args[0]);
            }    
            else
            {
                Console.WriteLine("Error: Not valid command");
            }
        }
    }
}