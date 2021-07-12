using System;

namespace Minimall.Products
{
    public class FoodProduct : Product
    {
        public bool Perishable { get; set; }
        public DateTimeOffset Expiration { get; set; }

        public FoodProduct(string name, decimal price, DateTimeOffset expiration)
            : base(name, price)
        {
            Expiration = expiration;
            Perishable = true; //If a FoodProduct has an expiration date it is considered perishable
        }

        public FoodProduct(string name, decimal price) 
            : base(name, price)
        {
            Perishable = false; //If it does not have an expiration date, it is considered non-perishable
        }

        public bool Expired()
        {
            try
            {
                return Expiration.UtcDateTime < DateTimeOffset.UtcNow;
            }
            catch (NullReferenceException e)
            {
                return false;
            }
        }

        public override void PrintDescription()
        {
            Console.WriteLine($"Name: {Name}, Perishable: {Perishable}");
        }
    }
}
