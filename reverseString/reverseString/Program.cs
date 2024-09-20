using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to reverse:");
            string input = Console.ReadLine();

            string reversedString = ReverseString(input);

            Console.WriteLine($"Reversed string: {reversedString}");
            Console.ReadLine();
        }

        static string ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
