using OrderSystem.Multiple.Patterns.Models;
using OrderSystem.Multiple.Patterns.Strategy;

namespace OrderSystem.Multiple.Patterns.Template
{
    public class StoreOrderProcessor : OrderProcessor
    {
        public StoreOrderProcessor(IPaymentStrategy payment, IDiscountStrategy discount) : base(payment, discount) { }

        protected override void ApplyBusinessRules(Order order)
            => Console.WriteLine("[Rules] Store: pickup rules + store discount eligibility.");
    }



}
