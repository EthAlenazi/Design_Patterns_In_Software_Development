namespace without_Strategy_Pattern
{
    public class CreditCardPayment : IPaymentStrategy
    {
        public void Pay(decimal amount) => Console.WriteLine($"Paid {amount} using Credit Card");
    }

   
}
