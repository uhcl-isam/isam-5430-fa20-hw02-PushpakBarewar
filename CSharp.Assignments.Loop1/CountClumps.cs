using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// Create an app that lets you enter a bunc hof integers until the
    /// end of line with a CTRL-Z. We will say that a "clump" of these numbers
    /// is a series of 2 or more adjacent elements of the same value. The app will
    /// simply print out the number that is the count of these clumps.
    /// </summary>
    public class CountClumps
    {
        public static void Main()
        {
            Console.Error.WriteLine("Enter the numbers");
            string readline = Console.ReadLine();
            int n1 = Convert.ToInt32(readline);
            int c1 = 0, c2 = 0,count =1;
            while (readline != null)
            {
                string s = Console.ReadLine();
                if (s == null)
                {
                    if (c2 > 0)
                        c1 += 1;
                    break;
                }
                   
                int n2 = Convert.ToInt32(s);
                if (n1 == n2)
                    c2 += 1;
                else
                {
                    n1 = n2;
                    if (c2 > 0)
                    {
                        c1 += 1;
                        c2 = 0;
                     }      
                 }
             }
            Console.WriteLine(c1);
        }
    }
}
