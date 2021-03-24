using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;
using static Solving.MethodsCW;
using static System.Char;




namespace CodeWarsSolving
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>();
            words.AddRange(new string[] { "abab", "sdas" });
            foreach(string s in Anagrams("aabb", words))
            {
                Console.WriteLine(s);
            }
            
        }
    }
}