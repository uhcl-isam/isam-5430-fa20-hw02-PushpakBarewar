using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Assignments.Loop1
{
    public class SquareUp
    {
        /// <summary>
        /// Create an app that inputs one number, 
        /// n >= 0. The app will print out n*n integers with the following pattern; 
        /// for n=3, the app will print out 0, 0, 1,    0, 2, 1,    3, 2, 1 on separate lines (spaces added to show the 3 groups).
        /// </summary>
        public static void Main()
        {
            Console.Error.WriteLine("Enter the value of n such that it is greater than/equal to zero");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i<=n ; i++)
            {
                int k = n;
                for (int j = n; j>=1 ; j--)
                {
                    int c = j - k;
                    Console.Write($"{c},");
                    if (k > (i+1))
                        k = k-1;
                    else
                        k = 0;

                }
                Console.WriteLine();
            }
        }
    }
}
