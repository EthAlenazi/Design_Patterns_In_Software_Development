using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    //Concrete Strategies
    public class ApplePayPayment : IPaymentStrategy
    {
        public void Pay(decimal amount)
            => Console.WriteLine($"[ApplePay] Paid {amount}");
    }

}
