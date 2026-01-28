namespace OrderSystem.Multiple.Patterns.Strategy
{
    public class CreditCardPayment : IPaymentStrategy
    {
        public void Pay(decimal amount) =>
            Console.WriteLine($"[Payment] Paid {amount} using Credit Card.");
    }
}
