using System;

namespace Tesseract.Tests
{
    // credit via:
    // http://kenthall.wordpress.com/2006/09/09/debugging-nunit-test-within-c-express/
    public class NUnitConsoleRunner
    {
        [STAThread]
        static void Main(string[] args)
        {
            NUnit.ConsoleRunner.Runner.Main(args);
        }

        
    }

   
}
