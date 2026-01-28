using OrderSystem.Multiple.Patterns.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem.Multiple.Patterns.Strategy
{
    public class NoDiscount : IDiscountStrategy
    {
        public decimal ApplyDiscount(Order order, decimal currentAmount)
        {
            Console.WriteLine("[Discount] No discount applied.");
            return currentAmount;
        }
    }

}
