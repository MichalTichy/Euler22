using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler22
{
    class Program
    {
        static void Main(string[] args)
        {
            var totalSum = 0;

            var names = GetNames("p022_names.txt").ToArray();

            for (int i = 0; i < names.Length; i++)
            {
                totalSum += GetStringValue(names[i]) * (i+1);
            }
            
            Console.WriteLine(totalSum);
            Console.ReadKey();

        }

        public static IOrderedEnumerable<string> GetNames(string source)
        {
            return File.ReadAllText(source).Replace("\"", string.Empty).Split(',').OrderBy(s => s);
        }

        public static int GetCharValue(char input)
        {
            return input - 64;
        }

        public static int GetStringValue(string input)
        {
            return input.Sum(GetCharValue);
        }

    }
}
