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
            string z = "s s sffs, oprit sffs fsdg fsdg fsdg";
            List<string> allElems = new List<string>();
            Hashtable rez = new Hashtable();
            string toCount = "";
            int max = 0;
            
            allElems.AddRange(z.ToLower().Replace(",", "").Split(' '));


            for (int i = 0; allElems.Count > 0; i++)
            {
                toCount = allElems[0];
                rez.Add(toCount,allElems.RemoveAll(x => x == toCount));
            }
            ICollection values = rez.Values;
            
            do
            {
                
                // 1. Напиши метод поиска максимального ключа/значения в хештаблице;
                // 2. Сделай логику удаления макс элемента и добавления его в возвращаемый список только строкового представления;
            } while (rez.Count > 0);
            

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
