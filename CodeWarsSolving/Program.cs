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

            //string s = "PIZDA PIZDA 3 132 12 12. 12$ 12: 132; 132, a a a a a a a a a a a a a";

            //char[] chTosort = s.ToCharArray();

            //IEnumerable<char> toSort = chTosort.Where(ch => !(Char.IsPunctuation(ch)));
            //chTosort = toSort.ToArray();
            //s = "";
            //foreach (char ch in chTosort)
            //{
            //  s += ch;
            //}
            //Console.WriteLine(s);
            string test1 = "  ...  ";
            List<string> a = Top3(test1);
           
            int i = 1;
            foreach (string z in a)
            {
                Console.Write($"{i}) z = @{z}@\n");
                i++;
            }
            int y = 0;


                



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
