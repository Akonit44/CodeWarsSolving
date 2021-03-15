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
            // int[] carpark = { 1, 0, 0, 0, 2 };
            //int carI = 0, stairI = 0;
            //for (int i = 0; i< carpark.Length;i++)
            //{
            //  if(carpark[i] == 2)
            //{
            //  carI = i;
            //}
            //else if (carpark[i] == 1)
            //{
            //   stairI = i;
            //    }
            //}
            //string direction = (stairI > carI)? "R":"L" ;
            //Console.WriteLine($"stair = {stairI}, car = {carI} {direction}{((stairI > carI)? stairI - carI : carI - stairI)}");
            string a = "ehvekwke";
            Console.WriteLine(DuplicateEncode(a));
            HashSet<char> hs = new HashSet<char>();
            int[] intA = {1,1,22,22,4,3,3,4 };
            HashSet<int> intHs = new HashSet<int>();
            
            foreach(int ab in intA)
            {
                intHs.Add(ab);
            }
            foreach(int ab in intHs)
            {
                Console.Write(ab + " |");
            }


        }
    }
}