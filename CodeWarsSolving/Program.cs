﻿using System;
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
            List<string> Candidates = new List<string>();
            string toCompare = "abba";

            Candidates.AddRange(new string[] { "abab", "sdas" });

            List<char> toCompare_List = new List<char>(toCompare.ToCharArray());
            List<char> rez = new List<char>();
            toCompare = "";
            toCompare_List.ForEach(a => toCompare+=(char)(a + 1) );

            Console.WriteLine(toCompare);
            //Console.WriteLine(new string(words[0].Union(word).ToList().ToArray()));
            //var rez = words.Where(wrd => wrd.Union(word).Count() == word.Length).ToList<string>();

 
 //           foreach (var a in rez)
   //         {
     //           Console.WriteLine(a);
       //     }
        }
    }
}