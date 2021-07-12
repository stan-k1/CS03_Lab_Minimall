namespace Minimall.Orders
{
    public record Payment
    {
        public decimal BaseAmount { get; set; }
        public decimal Discount { get; set; }
        public decimal FinalAmount { get; set; }
        public PaymentType PaymentType { get; set; }

        public Payment(decimal baseAmount, decimal discount, PaymentType paymentType)
        {
            BaseAmount = baseAmount;
            Discount = discount;
            PaymentType = paymentType;
            FinalAmount = BaseAmount - Discount;
        }
    }
}
