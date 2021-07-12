using System;
using System.Collections.Generic;
using Minimall.Orders;

namespace Minimall
{
    public interface ICustomer
    {
        public List<Order> Orders { get; set; }

        public bool AddOrder(Order order)
        {
            try
            {
                Orders.Add(order);
                return true;
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                return false;
            }
        }

        public bool RemoveOrder(Order order)
        {
            try
            {
                Orders.Remove(order);
                return true;
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                return false;
            }
        }

        public void PrintCustDetails();
    }
}
