using System;
using System.Collections.Generic;
using Minimall.Orders;
using Minimall.Persons;
using Minimall.Products;

namespace Minimall
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Business business = new Business("ExampleCompany", new Address(1, "ExampleStreet", "Athens", "Greece"));
            Order order = new Order(
                DateTime.UtcNow, 
                new List<Product>(), 
                new Payment(100.5m, 50m, PaymentType.Credit),
                business);
            ICustomer businessC = (ICustomer) business;
            businessC.AddOrder(order);
            businessC.PrintCustDetails();

        }
    }
}
