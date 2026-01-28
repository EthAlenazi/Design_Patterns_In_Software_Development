using OrderSystem.Multiple.Patterns.Models;
using OrderSystem.Multiple.Patterns.Strategy;

namespace OrderSystem.Multiple.Patterns.Template
{
    public abstract class OrderProcessor
    {
        private readonly IPaymentStrategy _payment;
        private readonly IDiscountStrategy _discount;

        protected OrderProcessor(IPaymentStrategy payment, IDiscountStrategy discount)
        {
            _payment = payment;
            _discount = discount;
        }

        // ✅ Template Method: السيناريو ثابت
        public void Process(Order order)
        {
            Validate(order);
            ReserveInventory(order);
            ApplyBusinessRules(order);

            var finalAmount = _discount.ApplyDiscount(order, order.Amount); // ✅ Strategy #1
            _payment.Pay(finalAmount);                                      // ✅ Strategy #2

            Confirm(order, finalAmount);
        }

        protected virtual void Validate(Order order)
            => Console.WriteLine($"[Validate] Order {order.Id} is valid for {order.CustomerName}.");

        protected virtual void ReserveInventory(Order order)
            => Console.WriteLine($"[Inventory] Reserved items for order {order.Id}.");

        // تختلف حسب نوع الطلب (inheritance)
        protected abstract void ApplyBusinessRules(Order order);

        protected virtual void Confirm(Order order, decimal finalAmount)
            => Console.WriteLine($"[Confirm] Order {order.Id} confirmed. Final amount: {finalAmount}\n");
    }



}
