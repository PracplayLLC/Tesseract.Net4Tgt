using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tesseract_4Tgt
{
    public static class ConsoleLoadDll
    {
        public static void Main(string[] args)
        {
                var path = System.IO.Path.GetFullPath(System.IO.Path.Combine(System.IO.Path.GetFullPath(Environment.CurrentDirectory) + @"\", @"..\..\..\..\tessdata\"));
                Console.WriteLine("CurDirectory: " + Environment.CurrentDirectory);
                var eng = new Tesseract.TesseractEngine(path, "eng", Tesseract.EngineMode.Default);
                Console.WriteLine("Tesseract-Engine-Version: " + eng.Version);

            Console.ReadLine();
        }
    }
}
