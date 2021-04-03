using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;
using static Solving.MethodsCW;
using static System.Char;
using System.Reflection;
using System.Diagnostics;
using System.IO;


namespace CodeWarsSolving
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine(Convert.ToString(255, 16));
            
        }
        private static string generateWord() =>
         String.Concat(new char[rnd.Next(2, 12)].Select(_ => (char)rnd.Next(97, 123)));
    }
}