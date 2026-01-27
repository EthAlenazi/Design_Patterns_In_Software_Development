namespace without_Strategy_Pattern
{
    class Program
    {
        static void Main()
        {
            var ctx = new PaymentContext_Partial();
            ctx.ExecutePayment(PaymentType.CreditCard, 100);
            ctx.ExecutePayment(PaymentType.ApplePay, 200);
        }
    }

}
