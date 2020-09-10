using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Assignments.Loop1
{
    public class OddNumbers
    {
        /// <summary>
        /// First prompt for the start and the end number. 
        /// Then, Write all odd integers between start and ending number inclusive (in ascending order) on separate lines.
        /// </summary>

        public static void Main()
        {
            Console.Error.WriteLine("Enter the starting number");
            int str = int.Parse(Console.ReadLine());
            Console.Error.WriteLine("Enter the ending number");
            int end = int.Parse(Console.ReadLine());
           
            if((str%2) == 0)
            {
                for (int i = str+1; i <= end; i+=2)
                 Console.WriteLine(i);
            }
            else
            {
                for (int i = str; i <= end; i += 2)
                 Console.WriteLine(i); 
            }
        }
    }
}
