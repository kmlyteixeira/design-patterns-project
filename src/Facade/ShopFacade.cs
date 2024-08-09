namespace DesignPatternsProject.Facade
{
    public class ShopFacade
    {
        private OrderSystem _orderSystem;
        private PaymentGateway _paymentGateway;
        private DeliveryService _deliveryService;

        public ShopFacade()
        {
            _orderSystem = new OrderSystem();
            _paymentGateway = new PaymentGateway();
            _deliveryService = new DeliveryService();
        }

        public void PlaceOrder(string orderDetails, decimal amount, string deliveryAddress)
        {
            _orderSystem.PlaceOrder(orderDetails);
            _paymentGateway.ProcessPayment(amount);
            _deliveryService.ArrangeDelivery(deliveryAddress);
        }
    }
}
