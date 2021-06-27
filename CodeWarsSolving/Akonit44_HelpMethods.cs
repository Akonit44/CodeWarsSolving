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
        public static void showMass<T>(T[,] massArg)
        {
            for(int i =0; i < massArg.GetLength(0); i++) 
            {
                for (int j =0; j< massArg.GetLength(1); j++)
                {
                    Console.Write($"{massArg[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        public static void showMass<T>(List<T> list)
        {
            
            foreach(var elem in list)
            {
                Console.Write( $"{elem} ");
            }
        }
    }
}
