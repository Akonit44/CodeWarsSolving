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
            string z = "s sffs, oprit fsdg";
            List<string> a = new List<string>();
            Console.WriteLine(a.Count);
            a.AddRange(z.ToLower().Replace(",", "").Split(' '));
            foreach (string elem in a)
            {
                Console.WriteLine(elem + 10);
            }
            
        }
            
    }
}
