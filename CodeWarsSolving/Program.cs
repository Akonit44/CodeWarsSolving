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
            string z = "PIZDA PIZDA 3 132 12 12 12 12 132 132 a a a a a a a a a a a a a";
            List<string> allElems = new List<string>();
            List<string> rez = new List<string>();
            string toCount = "";
            SortedDictionary<string, int> a = new SortedDictionary<string, int>();
            
            allElems.AddRange(z.ToLower().Replace(",", "").Split(' '));
            
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
