using System;
using System.Collections.Generic;
using System.Collections;
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
            Console.WriteLine($"index of 2(car) {carpark[0,0]}\nIndex of 1(stair){carpark[0,1]}");
            
            return null;
        }
        public static int[] findIndexOf(int[,] carpark, int carOrStair)
        {
            int[] rezIndex = new int[2];
            for (int i = 0; i < carpark.GetLength(0); i++)
            {
                for (int j = 0; j < carpark.GetLength(1); j++)
                {
                    if(carpark[i, j] == carOrStair)
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
            List<string> allElems = new List<string>();
            List<string> rez = new List<string>();
            string toCount = "";
            SortedDictionary<string, int> a = new SortedDictionary<string, int>();

            allElems.AddRange(s.ToLower().Replace(",", "").Split(' '));

            for (int j = 0; allElems.Count > 0; j++)
            {
                toCount = allElems[0];
                a.Add(toCount, allElems.RemoveAll(x => x == toCount));
            }


            int[] mass = new int[a.Count];
            a.Values.CopyTo(mass, 0);
            Array.Sort(mass);
            Array.Reverse(mass);


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

            foreach (string aa in rez)
            {
                Console.WriteLine(aa);
            }
            return rez;
        }
    }
}
