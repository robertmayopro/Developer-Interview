using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mednax.DeveloperInterview
{
    public class ProgramHarness
    {
        private IOutputWriter _outputWriter;

        public ProgramHarness(IOutputWriter outputWriter)
        {
            _outputWriter = outputWriter;
        }

        public void WriteTriangle(int number, int width)
        {
            int i = width;
            while (i > 0)
            {
                for (int j = 0; j < i; j++)
                {
                    _outputWriter.Write(number.ToString());
                }

                _outputWriter.WriteLine();
                i--;
            }
        }

        public void WriteAverageSalaryByDepartment(IEnumerable<Employee> employees)
        {
            foreach (IGrouping<string, Employee> department in employees.GroupBy(e => e.Department))
            {
                decimal averageSalary = department.Average(d => (decimal)d.Salary);
                _outputWriter.WriteLine($"Department: {department.Key}, Avg. Salary: {averageSalary:c2}");
            }
        }


        public void WriteNumberAndFrequencyFromGivenArray(IEnumerable<int> numbers)
        {
            foreach(int distinctNumber in numbers.Distinct())
            {
                int count = numbers.Where(n => n == distinctNumber).Count();
                decimal frequency = (decimal)count / numbers.Count();

                _outputWriter.WriteLine($"The number {distinctNumber} occurs {count} time(s), {frequency:#.##%} of the time.");
            }
        }

        public bool IsPalindrome(string value)
        {
            return string.Equals(value, new string (value.Reverse().ToArray()), StringComparison.OrdinalIgnoreCase);
        }
    }
}
