using System;
using System.Collections.Generic;

namespace Mednax.DeveloperInterview
{
    //Question 1
    //Given an instance circle of the following class:
    //Write code to calculate the circumference of the circle, without modifying the Circle class itself
    public sealed class Circle
    {
        private double radius;
        public double Calculate(Func<double, double> op)
        {
            return op(radius);
        }
    }

    public class Circumference
    {
        public double Calculate(Circle circle)
        {
            //return circle.Calculate((r) => Math.PI * Math.Pow(r, 2));
            return circle.Calculate((r) => 2 * r * Math.PI);
        }
    }

    //Question 2
    //What is the output for the program below and explain answer.

    // 10 10's because i is 10 at the end of the loop. At the 
    // time the delegates are called, they are querying the
    // current value of i, not the stat of i as the delegate
    // was added to the list.
    public class program
    {
        delegate void Printer();

        static void Main()
        {
            List<Printer> printers = new List<Printer>();
            int i = 0;
            for (; i < 10; i++)
            {
                printers.Add(delegate { Console.WriteLine(i); });
            }

            foreach (var printer in printers)
            {
                printer();
            }
        }
    }

    //Question 3
    //What is the output of the program below and explain your answer..

    // You'll get 'location is null' because strings
    // are initialized to null and nothing in this
    // code ever changes that.

    // Then you'll get a string representation of "Day 1" (DateTime.MinValue)
    // because DateTime is an instrinsic value, it can never be set to null,
    // and is initialized to 1/1/0001
    class ProgramTwo
    {
        static String location;
        static DateTime time;

        static void Main()
        {
            Console.WriteLine(location == null ? "location is null" : location);
            Console.WriteLine(time == null ? "time is null" : time.ToString());
        }
    }

    //Question 4
    //Identify which line is boxing and which line is unboxing
    public class ProgramThree
    {
        static void Main()
        {    
            int x = 101;
            Object o = x; // Unboxing

            o = 999;
            x = (int)o; // Boxing
        }
    }
}
