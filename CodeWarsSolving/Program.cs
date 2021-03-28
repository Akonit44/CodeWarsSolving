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



namespace CodeWarsSolving
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> a = Anagrams("abba", new List<string>(new string[] {"aaaa","abab", "acab"}));

            foreach(string v in a)
            {
                Console.WriteLine(v);
            }
        }
    }
}