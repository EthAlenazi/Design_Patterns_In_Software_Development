using OrderSystem.Multiple.Patterns.Factory;
using OrderSystem.Multiple.Patterns.Models;

namespace OrderSystem.Multiple.Patterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var order = new Order(
                Id: "ORD-2001",
                Amount: 250.00m,
                CustomerName: "Atheer",
                IsFirstOrder: true
            );

            // Change it at run time:
            var orderType = "online";        // online | store | subscription
            var paymentType = "applepay";    // credit | applepay | bank
            var discountType = "first50";    // none | 10percent | first50

            var payment = PaymentFactory.Create(paymentType);
            var discount = DiscountFactory.Create(discountType);

            var processor = ProcessorFactory.Create(orderType, payment, discount);

            processor.Process(order);
        }
    }

   
}
