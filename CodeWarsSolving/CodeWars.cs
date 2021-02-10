﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            int[] toShow = new int[1] { 0 };
            toShow[0] = arr[0];
            int count = x - 1;

            for (int i = 1; i < arr.Length; i++)
            {
                Console.WriteLine($"first i = {i}");
                count = (i == 0) ? x - 1 : x;
                for (int j = 0; j < toShow.Length; j++)
                {
                    Console.WriteLine($"second j = {j}");
                    if (count != 0 & toShow[j] == arr[i])
                    {
                        toShow = AddElemToMass(toShow, arr[j]);
                        count--;
                    }
                    else if (toShow[j] != arr[i])
                    {
                        toShow = AddElemToMass(toShow, arr[j]);
                    }
                    MySharp.showMass(toShow);
                }
            }
            return toShow;
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
    }
}
