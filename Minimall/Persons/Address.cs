namespace Minimall.Persons
{
    public struct Address
    {
        public int Number { get; init; }
        public string Road { get; init; }
        public string City { get; init; }
        public string Country { get; init; }

        public Address(int number, string road, string city, string country)
        {
            Number = number;
            Road = road;
            City = city;
            Country = country;
        }

        public override string ToString()
        {
            return $"{Number}, {Road}, {City}, {Country}";
        }
    }
}
