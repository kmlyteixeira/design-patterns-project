namespace DesignPatternsProject.Facade
{
    public class OrderSystem
    {
        public void PlaceOrder(string orderDetails)
        {
            Console.WriteLine($"Order placed with details: {orderDetails}");
        }
    }
}
