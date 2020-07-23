using System;
using System.Collections.Generic;
using System.Linq;
using Examples.Extension;

namespace Examples
{
    class Program
    {
        private static void Main(string[] args)
        {
            ICustomerRepository customerRepository = new EfCustomerRepository();
            customerRepository.CreateCustomer();
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

    internal interface ICustomerRepository
    {
        void CreateCustomer();
    }

    internal class EfCustomerRepository : ICustomerRepository
    {
        void ICustomerRepository.CreateCustomer() => "EF Customer added.".Print();
    }

    internal class DpCustomerRepository : ICustomerRepository
    {
        void ICustomerRepository.CreateCustomer() => "DP Customer added.".Print();
    }
}