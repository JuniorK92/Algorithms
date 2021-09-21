using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int Sum_1(int x, int y)
        {
            return (x == y) ? ((x + y) * 3) : (x + y);
        }
        public int AbsoluteDifference(int n)
        {
            const int x = 51;

            return (n > x) ? ((n - x) * 3) : (x - n);
        }
        public bool NumberCheck(int x, int y)
        {
            return (x == 30 || y == 30 || (x + y) == 30);
        }
        public string IfStringInserter(string input)
        {
            return (input.Length > 2 && input.Substring(0, 2).Equals("if")) ? input : "if " + input;
        }
        public static string CharacterExchanger(string input)
        {
            var inputArray = input.ToCharArray();

            var firstChar = inputArray[0];
            inputArray[0] = inputArray[^1];
            inputArray[^1] = firstChar;

            return string.Concat(inputArray);
        }
        public static int Algo(IEnumerable<int> numbers)
        {
            return numbers.GroupBy(x => x).Where(x => x.Count() == 1).Select(x => x.First()).First();
        }
        
    }
}
