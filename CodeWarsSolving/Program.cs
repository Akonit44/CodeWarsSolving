using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;
using static Solving.MethodsCW;




namespace CodeWarsSolving
{
    class Program
    {
        static void Main(string[] args)
        {


            Hashtable dictionary1 = new Hashtable();
            Hashtable dictionary2 = new Hashtable();
            char ch = 'z';
            //Console.WriteLine(Rot13( "test"));
            for (int i = 0; i < 26; i++)
            {
                dictionary1.Add(i, (char)('a' + i));
                dictionary2.Add((char)('a' + i), i);
            }
            string message = "";
            //var raw1 = dictionary1[(((int)dictionary2[ch] + 13) % 26)];
            //message += raw1;
            //message += ((int)dictionary2[ch] + 13 > 25) ? (char)(int)dictionary1[(int)dictionary2[ch] + 13 % 25] : (char)((int)dictionary2[ch] + 13);
            //Console.WriteLine(((char)(int)dictionary1[(int)dictionary2[ch] + 13 % 25]));
            //message += (int)dictionary2[ch] + 13 > 25 ? (char)(int)dictionary1[(int)dictionary2[ch] + 13 % 25] : "false";
            Console.WriteLine(message);
        }
    }
}