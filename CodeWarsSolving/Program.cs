using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Solving.MethodsCW;
using System.Text.RegularExpressions;



namespace CodeWarsSolving
{
    
    class Program
    {
        static void Main(string[] args)
        {
            string test1 = "  //wont won't won't ";
            Akonit44_HelpMethods.showMass(Top3(test1));
            

            Regex regex = new Regex(@"(\w*)'(\w*)", RegexOptions.IgnorePatternWhitespace);
            
            

        }

    }
}
