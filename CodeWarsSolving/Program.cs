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
       
        static void Main(string[] args)
        {
            string input = "((()))";
            //bool linq = input.Where(x => x == ')').ToArray().Length == input.Where(y => y =='(').ToArray().Length;

            //bool rez = false;
            //for(int i =0; i<input.Length;i++)
            //{

            //    if ((input[i] != '(' || input[i] != ')') && input[0] != ')' && input[input.Length-1] !=')') { rez = false; break; }

            //    else rez = true;
            //}
            bool rez = false;
            for(int i = 0; i < input.Length; i++)
            {
                for(int j = i; j < input.Length; j++)
                {
                    if (input[i] == '(' && j > i && input[j] == ')')
                    {
                        Console.WriteLine("YES");
                        rez = true;
                    }
                    else { rez = rez; }
                }
            }


          
            Console.WriteLine(rez);
        }
       
    }
}