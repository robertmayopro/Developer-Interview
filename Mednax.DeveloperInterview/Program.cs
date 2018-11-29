using System;
using System.Collections.Generic;

namespace Mednax.DeveloperInterview
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PrintTriangle();
            PrintAverageSalaryByDepartment();
            DisplayNumberAndFrequencyFromGivenArray();
            PrintIsPalindrome();

            Console.ReadLine();
        }

        /// <summary>
        /// Write a program that takes a number and a width also a number, as input and then displays a triangle of that width, using that number
        ///
        /// Enter a number: 6
        /// Enter the desired width: 6
        ///
        /// Expected Output :
        ///
        /// 666666
        /// 66666
        /// 6666
        /// 666
        /// 66
        /// 6
        /// </summary>
        public static void PrintTriangle()
        {
            Console.WriteLine();
            Console.WriteLine("Coding Exercise #1: Print Triangle");
            Console.WriteLine();
            Console.WriteLine("Enter a number: ");

            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the desired width: ");
            int width = Convert.ToInt32(Console.ReadLine());
        }

        /// <summary>
        /// Print the average salary by department
        /// </summary>
        public static void PrintAverageSalaryByDepartment()
        {
            Console.WriteLine();
            Console.WriteLine("Coding Exercise #2: Print Average Salary By Department");
            Console.WriteLine();

            var employees = new List<Employee>
            {
                new Employee {Name = "Tom", Age = 32, Department = "Design", Salary = 120000},
                new Employee {Name = "John", Age = 22, Department = "UI", Salary = 86000},
                new Employee {Name = "Sandra", Age = 36, Department = "UI", Salary = 83000},
                new Employee {Name = "Julie", Age = 54, Department = "Javascript", Salary = 80000},
                new Employee {Name = "Samantha", Age = 21, Department = "Design", Salary = 125000}
            };
        }

        internal class Employee
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Department { get; set; }
            public int Salary { get; set; }
        }

        /// <summary>
        /// Display the number and frequency of number from given array
        /// </summary>
        public static void DisplayNumberAndFrequencyFromGivenArray()
        {
            int[] arr1 = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            Console.WriteLine();
            Console.WriteLine("Coding Exercise #3: Display the number and frequency of number from given array : ");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("The numbers in the array  are : ");
            Console.WriteLine(" 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2");
        }

        #region Palindrome 

        /// <summary>
        /// Write a method to determine if a string is a palindrome
        ///
        /// Definition of palindrome: a word, phrase, or sequence that reads the same backward as forward
        /// </summary>
        public static void PrintIsPalindrome()
        {
            Console.WriteLine();
            Console.WriteLine("Coding Exercise #4: Palindrome");
            Console.WriteLine();

            string[] array =
            {
                "civic",
                "deified",
                "deleveled",
                "devolved",
                "dewed",
                "Hannah",
                "kayak",
                "level",
                "madam",
                "racecar",
                "radar",
                "redder",
                "refer",
                "repaper",
                "reviver",
                "rotator",
                "rotor",
                "sagas",
                "solos",
                "sexes",
                "stats",
                "tenet",
                "Dot",
                "Net",
                "Perls",
                "Is",
                "Not",
                "A",
                "Palindrome",
                ""
            };

            foreach (string value in array)
            {
                Console.WriteLine("{0} = {1}", value, IsPalindrome(value));
            }
        }

        private static bool IsPalindrome(string value)
        {
            return true;
        }

        #endregion
    }
}
