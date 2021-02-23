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
            string z = "s sffs, oprit s s sffs fsdg";
            List<string> allElems = new List<string>();
            List<string> rez = new List<string>(new string[] { "", " " });
            
            string toCount = "";
            Hashtable a = new Hashtable();
            
            
            allElems.AddRange(z.ToLower().Replace(",", "").Split(' '));

            
            for (int j = 0; allElems.Count > 0; j++)
            {
                toCount = allElems[0];
                a.Add(toCount, allElems.RemoveAll(x => x == toCount));
            }
           
            
           
            int[] mass = new int[a.Keys.Count];
            int i = 0;
            foreach(string n in a.Keys)
            {
                mass[i] = (int)a[n];
                Console.WriteLine($"{a[n]} - {n}" );
                i++;
            }
            Array.Sort(mass);
            Array.Reverse(mass);
            Akonit44_HelpMethods.showMass(mass);
            allElems.AddRange(z.ToLower().Replace(",", "").Split(' '));

            for (int y = 0; (y < 3) && (y < mass.Length);y++)
            {
                rez.Add((string)a[mass[y]]);
            }
            Console.WriteLine(a["s"]);
            foreach(string elem in rez)
            {
                Console.WriteLine(elem);
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
