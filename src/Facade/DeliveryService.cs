namespace DesignPatternsProject.Facade
{
    public class DeliveryService
    {
        public void ArrangeDelivery(string deliveryAddress)
        {
            Console.WriteLine($"Delivery arranged to: {deliveryAddress}");
        }
    }
}
