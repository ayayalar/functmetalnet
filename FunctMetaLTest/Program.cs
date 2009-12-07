using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FunctMetaL.Core;

namespace FunctMetaLTest
{
    class Program
    {
        static void Main(string[] args)
        {
            FunctMetaL.Core.Main main = new Main();
            main.TestSuite = @"C:\Projects\FunctMetaL\Xml\AcceptanceTest.xml";
            main.Start();
            Console.ReadLine();
        }
    }
}
