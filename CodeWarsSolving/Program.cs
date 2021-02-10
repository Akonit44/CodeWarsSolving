using System;
using System.Collections.Generic;
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
            Akonit44_HelpMethods.showMass(findIndexOf(new int[,]
                        { { 1, 0, 0, 0, 2 },
                        { 0, 0, 0, 0, 0 } }, 1));
        }
    }
}
