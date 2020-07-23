using System;
using System.Collections.Generic;
using Examples.Extension;

namespace Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            // "Hello World!".Print(); Extension Method
            
            var numbers = new List<int>{0,1,2,3,4,5,6,7,8,9};
            
            var action = new Action<int>(GetNumber);

            numbers.ForEach(action);
            
        }

        private static void GetNumber(int obj) => Console.WriteLine(obj.ToString());
    }
}