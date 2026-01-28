using OrderSystem.Multiple.Patterns.Models;
using OrderSystem.Multiple.Patterns.Strategy;

namespace OrderSystem.Multiple.Patterns.Template
{

    public class OnlineOrderProcessor : OrderProcessor
    {
        public OnlineOrderProcessor(IPaymentStrategy payment, IDiscountStrategy discount) : base(payment, discount) { }

        protected override void ApplyBusinessRules(Order order)
            => Console.WriteLine("[Rules] Online: shipping rules + address validation.");
    }
}
