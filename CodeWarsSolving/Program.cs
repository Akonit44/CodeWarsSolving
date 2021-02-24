using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Solving.MethodsCW;



namespace CodeWarsSolving
{
    
    class Program
    {
        static void Main(string[] args)
        {
            
            string z = "PIZDA PIZDA 3 132 12 12. 12$ 12: 132; 132, a a a a a a a a a a a a a";

            char[] a =(char[]) z.ToCharArray().Where((x)=>!char.IsPunctuation(x) );
            Akonit44_HelpMethods.showMass(a);

            

            //string toCount = "";
            //int[] topThree = new int[3];
            //int index = 0;
            //for (int i = 0; i < a.Count; i++)
            //{
            //    index = topThree[index] > 0 ? index += 1 : index;
            //    toCount = a[i];
            //    foreach (string elem in a)
            //    {
            //        if (elem == toCount)
            //        {
            //            topThree[index]++;
            //        }
            //        Console.Write(elem + "| ");
            //    }
            //    a.RemoveAll(x => x == toCount);
            //}

            //Akonit44_HelpMethods.showMass(topThree);

        }

    }
}
