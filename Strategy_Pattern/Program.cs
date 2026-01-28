namespace Strategy_Pattern
{
    class Program
    {
        static void Main()
        {
            PaymentContext payment = new PaymentContext(new CreditCardPayment(),new WorkFlow1());

            payment.ExecutePayment(100);

            // behavioral change while run time
            payment.ChangeStrategy(new ApplePayPayment());
            payment.ExecutePayment(200);
    
            payment.ChangeStrategy(new StcPayPayment());
            payment.ExecutePayment(300);


        }
    }

}
