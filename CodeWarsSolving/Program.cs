using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;
using static Solving.MethodsCW;




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

            string str = "(()aas";
            string rez = "";
            List<char> list = new List<char>();
            list.AddRange(str.ToArray());
            list.ForEach(elem => rez += (str.IndexOf(elem) != str.LastIndexOf(elem)) ? ")" : "(");
            Console.WriteLine(rez);
            
        }
    }
}