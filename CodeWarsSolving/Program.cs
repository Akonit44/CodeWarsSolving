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
            // Console.WriteLine(IsPalindrom("asaad","daasa"));
            int[,] mass_2 = new int[3, 2];
            Console.WriteLine(mass_2.GetLength(1));
            for (int i = 0;i< mass_2.GetLength(1);i++)
            {
                mass_2[1, 1] = 1;
            }
            Akonit44_HelpMethods.showMass(mass_2);
        }

        public static bool IsPalindrom(string candidate1, string candidate2)
        {
            char[] a, b;
            //bool isPal = false;
            Array.Sort(a = candidate1.ToCharArray());
            Array.Sort(b = candidate2.ToCharArray());
            candidate1 = new string(a); 
            candidate2 = new string(b);
            return candidate1 == candidate2;
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
        public static bool isNotRepeat(string toTest)
        {
            bool rez = false;
            for (int i = 0; i < toTest.Length; i++)
            {
                for (int j = i+1; j < toTest.Length; j++)
                {
                    rez = toTest[i] == toTest[j];
                    if (rez)
                    {
                        return false;
                    }
                }
            }
                     return true;
        }
        public static string ChangeSpace(string input)
        {
            Regex regex = new Regex(@"\s+");
            return regex.Replace(input,"%20");
        }
    }
}