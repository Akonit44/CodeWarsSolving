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
            List<string> words = new List<string>();
            string word = "abba";
            words.AddRange(new string[] { "abab", "sdas" });
            List<char> a = new List<char>(word.ToCharArray());
            List<char> rez = new List<char>(new char[] {'v','a','c','a' });
            a.ForEach(ch => ); 
            //Console.WriteLine(new string(words[0].Union(word).ToList().ToArray()));
            //var rez = words.Where(wrd => wrd.Union(word).Count() == word.Length).ToList<string>();

 
 //           foreach (var a in rez)
   //         {
     //           Console.WriteLine(a);
       //     }
        }
    }
}