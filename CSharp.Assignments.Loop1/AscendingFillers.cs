using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// Create an application that reads a bunch of non-negative integers line-by-line until a negative integer or the end-of-line (CTRL-Z)
    /// has reached. The app will print out the sum of all the fillers that will make all the values entered so far will appear in increasing
    /// order, where each value is larger than the previous number. That is each filler is added to each input,
    /// such that the numbers will all appear in increasing order (e.g. 1, 2, 3, 10). The only exception is when the element is 0,
    /// where the current number and the subsequent numbers will restart from zero.
    /// </summary>
    /// <param name="a"></param>
    /// <remarks>In essence, this app will calculate the sum of all these values added to the original numbers such that our projected numbers will appear in increasing order.</remarks>
    /// <returns>The sum of all the fillers</returns>
/*Previous number =0
  Current number = n
  {
   If CN< 0 (or CTRL-Z)
   Break

   Else If CN ==0
   PN =0
   Filler =0

   Else If CN <= PN
   Filler = (PN + 1) - CN
   CN = PN+1

   PN = CN
   Sum += Filler
  }

  Print Sum*/
    public class AscendingFillers
    {
        public static void Main()
        {
            int pn = 0, filler = 0, sum = 0;

            while (true)
            {
                Console.WriteLine("Enter non negative integers");
                filler = 0;
                string cnn = Console.ReadLine();
                int cn = Convert.ToInt32(cnn);
                if ((cn < 0)|(cnn == null))
                {
                    break;
                }

                else if (cn <= pn && cn != 0)
                {
                    filler = (pn + 1) - cn;
                    cn = pn + 1;
                }

                pn = cn;
                sum += filler;
                //Console.WriteLine(sum);
                //Console.WriteLine(filler);

            }
            Console.WriteLine(sum);

        }
    }
}