using System;
using Examples.Extension;

namespace Examples
{
    delegate void MyDelegate(int numberOne, int numberTwo);
    class Program
    {
        static void Main(string[] args)
        {
            // "Hello World!".Print(); Extension Method
            var dDelegate = new MyDelegate(Sum);
            dDelegate += Multiply;
            dDelegate.Invoke(2,3);
        }
        public static void Sum(int numberOne, int numberTwo) => Console.WriteLine(numberOne + numberTwo);
        public static void Multiply(int numberOne, int numberTwo) => Console.WriteLine(numberOne * numberTwo);
    }
}