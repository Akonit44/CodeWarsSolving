﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;
using CodeWarsSolving;
using System.Diagnostics;
using static System.Char;
using System.Data.Common;
using System.Data;

namespace Solving
{
    class MethodsCW
    {
        public static int[] TwoSum(int[] numbers, int target)
        {
            int[] indexOftargetSum = new int[2] { 0, 0 };
            int toFind = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                toFind = target - numbers[i];
                indexOftargetSum[0] = i;

                for (int j = i; j < numbers.Length - 1; j++)
                {

                    if (toFind == numbers[j + 1])
                    {

                        indexOftargetSum[1] = j + 1;
                        i = numbers.Length;
                    }
                }

            }
            return indexOftargetSum;
        }
        public static string[] Solution(string str)
        {
            if (str.Length % 2 != 0) str += "_";
            string[] rez = new string[str.Length / 2];

            for (int i = 0; i < rez.Length; i++)
            {
                rez[i] = str.Substring(i * 2, 2);
            }

            return rez;
        }
        public static int TrailingZeros(int n)
        {
            int rez = 0;
            for (int i = 1; i <= Math.Log((double)n, 5); i++)
            {
                rez += (int)((double)n / Math.Pow(5, (double)i));
            }
            return rez;
        }
        /// <summary>
        /// Не законченное задание 
        /// </summary>
        /// <param name="lng"></param>
        /// <param name="wdth"></param>
        /// <returns></returns>
        public static List<int> sqInRect(int lng, int wdth)
        {
            int side = int.MaxValue;
            List<int> rez = new List<int>();
            if (lng == wdth) return null;
            else
            {
                for (int i = 0; side != 1; i++)
                {
                    if (i == 0) rez.Add((lng > wdth) ? wdth : lng);
                    else
                    {
                        side = (lng > wdth) ? lng -= wdth : wdth -= lng;
                        rez.Add(side);
                    }
                }
            }
            rez.Add(side);
            return rez;
        }

        public static int[] DeleteNth(int[] arr, int x)
        {
            int count = x;
            Hashtable ListOfElems = new Hashtable();
            List<int> toReturn = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (!ListOfElems.ContainsKey(arr[i]))
                {
                    ListOfElems.Add(arr[i], count);
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {

                if (ListOfElems.ContainsKey(arr[i]) && (int)ListOfElems[arr[i]] > 0)
                {
                    toReturn.Add(arr[i]);
                    ListOfElems[arr[i]] = (int)ListOfElems[arr[i]] - 1;
                }
            }

            return toReturn.ToArray();
        }

        public static int[] AddElemToMass(int[] massToExpand, int toAdd)
        {
            int[] expanded = new int[massToExpand.Length + 1];
            expanded[expanded.Length - 1] = toAdd;
            for (int i = 0; i < massToExpand.Length; i++)
            {
                expanded[i] = massToExpand[i];
            }
            return expanded;
        }

        public static string[] escape(int[,] carpark)
        {
            Console.WriteLine($"index of 2(car) {carpark[0, 0]}\nIndex of 1(stair){carpark[0, 1]}");

            return null;
        }
        public static int[] findIndexOf(int[,] carpark, int carOrStair)
        {
            int[] rezIndex = new int[2];
            for (int i = 0; i < carpark.GetLength(0); i++)
            {
                for (int j = 0; j < carpark.GetLength(1); j++)
                {
                    if (carpark[i, j] == carOrStair)
                    {
                        rezIndex[0] = i;
                        rezIndex[1] = j;
                    }
                }
            }
            return rezIndex;
        }

        public static List<string> Top3(string s)
        {


            s = Regex.Replace(s, @"(^\s+)(\W+)", "");
            Regex regex = new Regex(@"[a-z']*(\s)");

            MatchCollection collect = regex.Matches(s);




            foreach (var elem in collect)
            {
                //DEBUG

                s += elem;
            }

            List<string> allElems = new List<string>();
            List<string> rez = new List<string>();
            string toCount = "";
            SortedDictionary<string, int> a = new SortedDictionary<string, int>();

            allElems.AddRange(s.Split(' '));
            allElems.RemoveAll((x) => x == "");
            for (int j = 0; allElems.Count > 0; j++)
            {
                toCount = allElems[0];
                a.Add(toCount, allElems.RemoveAll(x => x == toCount));
            }

            int[] mass = new int[a.Count];
            a.Values.CopyTo(mass, 0);
            Array.Sort(mass);
            Array.Reverse(mass);

            //DEBUG
            Akonit44_HelpMethods.showMass(mass);

            for (int i = 0; i < mass.Length && i < 3;)
            {
                foreach (string Key in a.Keys)
                {
                    if (i < mass.Length && i < 3 && a[Key] == mass[i])
                    {
                        rez.Add(Key);
                        i++;
                    }
                }
            }

            return rez;
        }

        public static string DuplicateEncode(string word)
        {
            word = word.ToLower();
            string rez = "";
            List<char> list = new List<char>();
            list.AddRange(word.ToCharArray());
            list.ForEach(elem => rez += (word.IndexOf(elem) != word.LastIndexOf(elem)) ? ")" : "(");
            return rez;
        }
        public static int[] ArrayDiff(int[] a, int[] b)
        {
            List<int> a1 = new List<int>();

            a1.AddRange(a);
            for (int i = 0; i < b.Length; i++)
            {
                a1.RemoveAll(x => x == b[i]);
            }

            return a1.ToArray();
        }



        public static string Rot13(string message)
        {
            char[] ch_mass = message.ToCharArray();
            Dictionary<int, char> dictionary_num = new Dictionary<int, char>();
            Dictionary<char, int> dictionary_char = new Dictionary<char, int>();
            for (int i = 0; i < 26; i++)
            {
                dictionary_num.Add(i, (char)('a' + i));
                dictionary_char.Add((char)('a' + i), i);
            }
            message = "";
            for (int i = 0; i < ch_mass.Length; i++)
            {
                try
                {
                    if (IsLetter(ch_mass[i])) message += dictionary_num[(dictionary_char[ch_mass[i]] + 13) % 26];
                    else message += ch_mass[i];
                }
                catch
                {
                    if (IsLetter(ch_mass[i])) message += ToUpper(dictionary_num[(dictionary_char[ToLower(ch_mass[i])] + 13) % 26]);
                    else message += ch_mass[i];
                }
            }
            return message;
        }

        
        public static List<string> Anagrams(string word, List<string> words)
        {
            
            int wrd = word.Sum(x => x);
            List<string> rez = new List<string>();
           
            for(int i =0; i<words.Count; i++)
            {
                if (word.Length == words[i].Length && wrd == words[i].Sum(x => x) && (!rez.Contains(words[i]) || word != words[i].ToString())) rez.Add(words[i]);   
            }
            return rez;
        }

        public static string Rgb(int r, int g, int b)
        {
            //Как насчет разбить получившиеся три строки на один символьный массив
            //или список для его модификации и передачи в конструктор новой строки???)))
            char[] ch_mass = CheckRet(r).ToCharArray();

            string CheckRet(int R_G_B_elem)
            {

                if (R_G_B_elem > 255) R_G_B_elem = 255;
                else if (R_G_B_elem < 0) R_G_B_elem = 0;
                string to_check = Convert.ToString(R_G_B_elem, 16);
                to_check = (to_check.Length == 2) ? to_check : (to_check.Length == 1) ? "0" + to_check : to_check; 

                return to_check.ToUpper();

            }

            return CheckRet(r)+CheckRet(g)+CheckRet(b);
        }
        /// <summary>
        /// Не решил(. 4 куя как-никак
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int ParseInt(string s)
        {
            string[] mass = s.Split(' ');
            int rez = 0;
            int coff = 1;
            
            foreach(string word in mass) { 
            switch (word)
            {
                    case "one":
                        rez += 1;
                        break;

            }
            }
            return rez;
        }
    }
}
