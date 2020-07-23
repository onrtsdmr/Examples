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
        }
    }

    internal class Customer
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    internal class CustomerValidator
    {
        public static bool NameValidator(string name) => string.IsNullOrWhiteSpace(name) ? false : true;
    }

    internal class EfCustomerRepository
    {
        // Db saved.
    }
}