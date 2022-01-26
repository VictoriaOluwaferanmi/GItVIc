using System;

namespace Testability_and_Interface
{
    public class OrderProcessor
    {
        private readonly ShoppingCalculator _shippingCalculator;

        public OrderProcessor()
        {
            _shippingCalculator = new ShoppingCalculator();
        }

        public void Process(Order order)
        {
            if (Order.IsShipped)
                throw new Exception("");
            order.Shi
        }
    }
}