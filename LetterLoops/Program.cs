using System;
using System.Collections.Generic;
using System.Text;

namespace LetterLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            var newString = new List<string> {};
            StringBuilder myString = new StringBuilder();
            newString.Add(Console.ReadLine());

            myString.AppendJoin("-", newString);

            Console.WriteLine(myString.ToString());
        }
    }
}
