using System;
namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// A palindrome is a sequence of characters that reads the same backward
    /// as forward. For example, each of the following five-digit integers
    /// is a palindrome: 12321, 55555, 45554 and 11611.
    /// Write an app that reads in exactly 9-digit positive integers
    /// and determines whether it’s a palindrome (display either:
    /// "a palindrome" or "not a palindrome"). If the number is not
    /// nine digits long, display an error message and allow the user to
    /// enter a new value. </summary>
    /// <remark>[Hint: Use the remainder and division operators to pick off
    /// the number’s digits one at a time, from right to left.]</remark>
    ///
    public class IntegerPalindromes
    {
        public static void Main()
        {
            int c, n, k, rev = 0;
            bool ic = true;    
            do
            {

                c = 0;
                Console.Error.WriteLine("Enter the 9 digit number to be checked");
                n = int.Parse(Console.ReadLine());
                int j = n;
                for (; j >= 1 || c < j; j /= 10)
                    c = c + 1;


                if (c != 9)
                {
                    Console.Error.WriteLine("Kindly Enter only 9 digit number");
                    ic = true;
                }
                else
                {
                    ic = false;
                    k = n;

                    for (; n >= 1; n /= 10)
                        rev = rev * 10 + (n % 10);

                    if (rev == k)
                        Console.WriteLine("a palindrome");
                    else
                        Console.WriteLine("not a palindrome");

                }


            } while (ic);



        }
    }
}