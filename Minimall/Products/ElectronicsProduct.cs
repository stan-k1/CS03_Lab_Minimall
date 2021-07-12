using System;

namespace Minimall.Products
{
    public class ElectronicsProduct : Product
    {
        public bool IncludesCharger { get; set; } = false;

        public ElectronicsProduct(string name, int price)
            : base(name, price)
        { }

        public ElectronicsProduct(string name, int price, bool includesCharger)
            : base(name, price)
        {
            IncludesCharger = includesCharger;
        }

        public override void PrintDescription()
        {
            Console.WriteLine($"Name: {Name}, Charger Included: {IncludesCharger}");
        }

    }
}
