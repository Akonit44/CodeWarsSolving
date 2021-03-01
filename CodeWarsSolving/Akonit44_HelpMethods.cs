using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolving
{
    class Akonit44_HelpMethods
    {
        public static void showMass<T>(T[] massArg)
        {
            foreach (var elem in massArg)
            {
                Console.Write(elem + " ");
            }
            Console.WriteLine();
        }
        public static void showMass<T>(List<T> list)
        {
            Console.WriteLine($"Count - {list.Count}");
            foreach(var elem in list)
            {
                Console.Write( $"{elem} ");
            }
        }
    }
}
