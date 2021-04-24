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
            string input = "((())())";
            Console.WriteLine(SkobkaDA(input));
            
            
        }

        public static bool SkobkaDA(string input)
        {
            
            int i = 0, j = 1;
            bool rez = false;
            while (i < input.Length && input[0] == '(' && input.Length % 2 == 0)
            {
                if (input[i] == '('){
                    while (j < input.Length) {

                        if (input[j] == ')') {
                            rez = true;
                            j++;
                            break;
                        }
                        j++;
                    }

                }
                if (j == input.Length - 1 && input[j] != ')') return rez = false;
                else i++;
            }
            return rez;
        }

       
    }
}