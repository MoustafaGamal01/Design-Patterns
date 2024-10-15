namespace DesignPatterns.SOLID
{
    public class Payment
    {
        public string Type { get; set; }

        public Payment(string type)
        {
            Type = type;
        }

        public string GetPaymentType()
        {
            return Type;
        }
    }
}