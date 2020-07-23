using System;
using System.Collections.Generic;
using System.Linq;
using Examples.Extension;

namespace Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            var func = new Func<string, bool>(Find);
            var names = new List<string>{"H", "E", "Hello"};
            foreach (var item in names.Where(func))
            {
                Console.WriteLine(item);
            }
        }

        private static bool Find(string arg) => arg == "Hello";
    }
}