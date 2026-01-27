namespace without_Strategy_Pattern
{
    public class StcPayPayment : IPaymentStrategy
    {
        public void Pay(decimal amount) => Console.WriteLine($"Paid {amount} using STC Pay");
    }

   
}
