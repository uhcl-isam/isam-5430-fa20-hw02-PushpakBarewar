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
            Console.WriteLine("Enter the values:");
            int c = 0;
            string s;
            do
            {
                s = Console.ReadLine();
                int t = Convert.ToInt32(s);
                int t1 =-32768;
                if (t == t1)
                    c += 1;
                else
                    t1 = t;


            } while (s!=null);

            Console.WriteLine(c);
        }
    }
}
