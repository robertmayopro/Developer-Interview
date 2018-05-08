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
        /// </summary>
        public static void PrintTriangle()
        {
            Console.WriteLine("Input a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the desired width: ");
            int width = Convert.ToInt32(Console.ReadLine());
        }

        /// <summary>
        /// Print the average salary by department
        /// </summary>
        public static void PrintAverageSalaryByDepartment()
        {
            var employees = new List<Employee>
            {
                new Employee {Name = "Tom", Age = 32, Department = "Design", Salary = 120000},
                new Employee {Name = "John", Age = 22, Department = "UI", Salary = 86000},
                new Employee {Name = "Sandra", Age = 36, Department = "UI", Salary = 83000},
                new Employee {Name = "Julie", Age = 54, Department = "Javascript", Salary = 80000},
                new Employee {Name = "Samantha", Age = 21, Department = "Design", Salary = 125000}
            };

            Console.WriteLine("Average salary by department: ");
        }

        /// <summary>
        /// Display the number and frequency of number from given array
        /// </summary>
        public static void DisplayNumberAndFrequencyFromGivenArray()
        {
            int[] arr1 = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
            Console.Write("\nLINQ : Display the number and frequency of number from given array : \n");
            Console.Write("---------------------------------------------------------------------\n");
            Console.Write("The numbers in the array  are : \n");
            Console.Write(" 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2\n");
        }

        #region Palindrome 

        /// <summary>
        /// Palindrome
        /// </summary>
        public static void PrintIsPalindrome()
        {
            string[] array =
            {
                "civic",
                "deified",
                "deleveled",
                "devoved",
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

        internal class Employee
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Department { get; set; }
            public int Salary { get; set; }
        }
    }
}
