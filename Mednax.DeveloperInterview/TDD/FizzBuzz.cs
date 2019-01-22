using System;

namespace Mednax.DeveloperInterview.TDD
{
    /// <summary>
    /// Write a program that prints the numbers from 1 to 100. But for multiples of three print "Fizz"
    /// instead of the number and for the multiples of five print "Buzz". For numbers which are multiples
    /// of both three and five print "FizzBuzz".
    /// i.e.:  "1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz 16 ..."
    /// </summary>
    public class FizzBuzz
    {
        public string Emit(int n)
        {
            if (n % 5 == 0 && n % 3 == 0) return "FizzBuzz";
            if (n % 5 == 0) return "Buzz";
            if (n % 3 == 0) return "Fizz";
            return n.ToString();
        }
    }

}
