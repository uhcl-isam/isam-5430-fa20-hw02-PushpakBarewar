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
            int c = 0, n,k,rev=0 ;
            bool ic = true;
            while(ic)
            {
                Console.Error.WriteLine("Enter the value of n such that it is greater than/equal to zero");
                n = int.Parse(Console.ReadLine());
                for (; n >= 0; n /= 10)
                    c = c + 1;
                if (c != 9)
                {
                    Console.WriteLine("Kindly Enter only 9 digit number");
                    ic = true;
                }
                else
                {
                    ic = false;

                    k = n;

                    for (; n >= 0; n /= 10)
                        rev = rev * 10 + (n % 10);
                    if (rev == k)
                        Console.WriteLine("Entered number is a Palendrom");
                    else
                        Console.WriteLine("Entered number is NOT a Palendrom");

                }
                    
            }
            




        }
    }
}
