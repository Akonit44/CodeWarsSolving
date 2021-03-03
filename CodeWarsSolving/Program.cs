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
            string s = " yfrkkh, yfrkkh_";

            //s = Regex.Replace(s, @"(\s{2,})", " ");
            
            //Regex regex = new Regex(@"[a-z]*(\'?)(\w){1}");

            //MatchCollection collect = regex.Matches(s);
            //Console.WriteLine(collect.Count);
            //s = "";
            //foreach (var elem in collect)
            //{
            //    s += elem;
            //}
            //Console.WriteLine(s);
             Akonit44_HelpMethods.showMass(Top3(s));
        }
    }
}