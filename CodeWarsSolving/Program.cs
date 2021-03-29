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


namespace CodeWarsSolving
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> a = Anagrams("xxxxx", new List<string>(new string[] { "xxxxx", "b", "c" }));

            foreach (string v in a)
            {
                Console.WriteLine(v);
            }

        }
    }
}