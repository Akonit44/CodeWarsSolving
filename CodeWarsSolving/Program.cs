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
            string a = "dind";
            Console.WriteLine(DuplicateEncode(a));
            HashSet<char> hs = new HashSet<char>();

            foreach(char ch in a.ToCharArray())
            {
                hs.Add(ch);
            }
            foreach(char ch in hs)
            {
                Console.WriteLine(ch);
            }


        }
    }
}