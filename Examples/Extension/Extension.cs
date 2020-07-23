using System;

namespace Examples.Extension
{
    public static class Extension
    {
        public static void Print(this String str) => Console.WriteLine(str);
    }
}