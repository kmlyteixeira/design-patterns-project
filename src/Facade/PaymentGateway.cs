namespace DesignPatternsProject.Facade
{
    public class PaymentGateway
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Payment of {amount:C} processed.");
        }
    }
}
