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
            //Akonit44_HelpMethods.showMass(DeleteNth(new int[] { 20, 37, 20, 21 }, 1));
            int[] testArr = new int[] { 20, 37, 20,37,44, 21, 37, 44, 44 };
            Hashtable test = new Hashtable();
            List<int> alreadyCounted = new List<int>();
            int count = 2;

            for (int i = 0; i < testArr.Length; i++)
            {
                count = 2;
                if (!alreadyCounted.Contains(testArr[i]))
                { 
                    alreadyCounted.Add(testArr[i]);
                    count--;
                }
                for(int j = i+1; j < testArr.Length - 1; j++)
                {
                    if(alreadyCounted.Contains(testArr[j]) && count != 0)
                    {
                        alreadyCounted.Add(testArr[j]);
                        count--;
                    }
                }
                
               
            }
            testArr = alreadyCounted.ToArray();
            Akonit44_HelpMethods.showMass(testArr);
        }
            
    }
}
