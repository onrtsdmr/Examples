using System;
using System.Collections.Generic;
using Examples.Extension;

namespace Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            var predicate = new Predicate<string>(Find);
            var names = new List<string>{"H","E","Hello"};

            Console.WriteLine(names.Find(predicate));
        }

        private static bool Find(string obj) => obj.ToLower() == "hello";
    }
}