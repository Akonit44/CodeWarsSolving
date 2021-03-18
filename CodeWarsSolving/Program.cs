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
            List<int> inz = new List<int>();
            inz.AddRange(new int[] { 4, 4, 5 });
            inz.RemoveAll(x => x == 4);
            foreach(int elem in inz)
            {
                Console.Write(elem + " ");
            }

            
        }
    }
}