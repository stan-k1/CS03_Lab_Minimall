using System;
using System.Collections.Generic;
using Minimall.Products;

namespace Minimall.Orders
{
    public class Order
    {

        public DateTime OrderDate { get; set; }
        public List<Product> Products { get; set; }
        public Payment Payment { get; set; }
        public ICustomer Customer;

        public Order(DateTime orderDate, List<Product> products, Payment payment, ICustomer customer)
        {
            OrderDate = orderDate;
            Products = products;
            Payment = payment;
            Customer = customer;
        }
    }
}