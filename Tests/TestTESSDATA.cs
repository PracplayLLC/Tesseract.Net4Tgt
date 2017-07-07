using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Tesseract.Tests
{
    /// <summary>
    /// easily locate TESSDATA files and paths
    /// </summary>
    public class TestTESSDATA
    {
        public static string Path { get { return RunTime_Path; } }

        public static string RunTime_Path 
        { 
            get 
            { 
                var cd = System.IO.Path.GetFullPath(Environment.CurrentDirectory)+@"\";
                var path = System.IO.Path.Combine(cd, @"..\..\..\..\tessdata\");
                var full = System.IO.Path.GetFullPath(path);
                return full;
            } 
        }
    }
}
