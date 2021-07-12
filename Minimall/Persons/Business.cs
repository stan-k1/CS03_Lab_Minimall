using System;
using System.Collections.Generic;
using Minimall.Orders;
using Minimall.Products;

namespace Minimall.Persons
{
    public class Business : ICustomer, ISupplier
    {
        public string Name { get; set; }
        public Address Address { get; set; }
        public List<Person> Buyers { get; set; } = new();
        public List<Order> Orders { get; set; } = new();

        public Business(string name, Address address)
        {
            Name = name;
            Address = address;
        }

        public void PrintCustDetails()
        {
            Console.WriteLine($"{Name} - {Address}");
        }

        public void Pay(decimal money)
        {
            Console.WriteLine($"Payment of {money} made to {Name}");
        }
    }
}
