using System;
using System.Collections.Generic;
using Minimall.Orders;

namespace Minimall.Persons
{
    public class Person : ICustomer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
        public List<Order> Orders { get; set; } = new();

        public Person(string firstName, string lastName, Address address)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
        }

        public void PrintCustDetails()
        {
            Console.WriteLine($"{FirstName} {LastName}, {Address}");
        }
    }
}
