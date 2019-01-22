using System;
using System.Collections.Generic;
using System.Text;

namespace Mednax.DeveloperInterview
{
    public class ProgramFizzBuzz
    {
        public static void Main(string[] args)
        {
            TDD.FizzBuzz fizzBuzz = new TDD.FizzBuzz();
            for (int i = 1; i <= 100; i++)
            {
                Console.Write(fizzBuzz.Emit(i));
                Console.Write(" ");
            }
        }
    }
}