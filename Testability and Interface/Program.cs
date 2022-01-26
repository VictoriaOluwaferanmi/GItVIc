using System;

namespace Testability_and_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
        var orderprocessor = new OrderProcessor();

        var order = new Order{DatePlaced=DateTime.Now,TotalPrice=100f}
        orderprocessor.Process(order);
        }
    }
}