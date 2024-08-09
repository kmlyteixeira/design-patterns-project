using DesignPatternsProject.Facade;
using System;

namespace DesignPatternsProject
{
    public class FacadeRunner
    {
        public static void RunFacadePattern()
        {
            var shopFacade = new ShopFacade();

            Console.WriteLine("Enter order details:");
            var orderDetails = Console.ReadLine() ?? string.Empty;

            Console.WriteLine("Enter payment amount:");
            decimal amount = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter delivery address:");
            var deliveryAddress = Console.ReadLine() ?? string.Empty;

            shopFacade.PlaceOrder(orderDetails, amount, deliveryAddress);

            Console.WriteLine("Order has been placed successfully!");
        }
    }
}
