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
            string z = "s sffs, oprit sffs fsdg";
            List<string> a = new List<string>();
            
            a.AddRange(z.ToLower().Replace(",", "").Split(' '));
            string toCount = "";
            int[] topThree = new int[3];
            for (int i = 0; i < a.Count;i++)
            {
                toCount = a[i];
                foreach (string elem in a)
                {
                    if(elem == toCount)
                    {
                        topThree[0]++;
                    }
                }
                a.RemoveAll((toCount) => { return true; });
            }
            Akonit44_HelpMethods.showMass(topThree);
            
        }
            
    }
}
