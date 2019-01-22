using System;
using System.Collections.Generic;
using System.Text;

namespace Mednax.DeveloperInterview
{
    public interface IOutputWriter
    {
        void Write(string s);
        void WriteLine();
        void WriteLine(string s);
    }

    public class ConsoleOutputWriter : IOutputWriter
    {
        public void Write(string s)
        {
            Console.Write(s);
        }

        public void WriteLine()
        {
            Console.WriteLine();
        }

        public void WriteLine(string s)
        {
            Console.WriteLine(s);
        }
    }
}
