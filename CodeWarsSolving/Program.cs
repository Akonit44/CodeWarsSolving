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
            
            const int Tests = 1000;
            StreamWriter stream = new StreamWriter(@"D:\test.txt");

            for (int i = 0; i < Tests; ++i)
            {

                string word = generateWord();
                List<string> words = new string[rnd.Next(3, 20)].Select(_ => rnd.Next(0, 2) == 0 ? String.Concat(word.OrderBy(__ => rnd.Next())) : generateWord()).ToList();

                //List<string> expected = solution(word, words);
                //List<string> actual = CodeWars.Anagrams(word, words);


                //Assert.AreEqual(expected, actual);
                stream.WriteLine("Test numer:{0}", i);
                foreach (string wrd in words)
                {
                    stream.Write(wrd + " ");
                }
                

            }
            
        }
        private static string generateWord() =>
         String.Concat(new char[rnd.Next(2, 12)].Select(_ => (char)rnd.Next(97, 123)));
    }
}