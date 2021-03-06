using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Solving.MethodsCW;
using System.Text.RegularExpressions;



namespace CodeWarsSolving
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "a a a  b  c c  d d d d  e e e e e";
            
            //s = Regex.Replace(s, @"(^\s+)", "");
            //Regex regex = new Regex(@"[a-z']*(\s)");
            
            //MatchCollection collect = regex.Matches(s);
            //Console.WriteLine(collect.Count);
            //foreach (var elem in collect)
            //{
              //  s += elem;
            //}
            
            Akonit44_HelpMethods.showMass(Top3(s));
        }
    }
}