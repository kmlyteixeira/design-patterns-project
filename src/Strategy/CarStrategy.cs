namespace DesignPatternsProject.Strategy
{
    public class CarStrategy : ITransportationStrategy
    {
        private const double Cost = 50.0;
        private const double TimeRequired = 30.0;

        public bool CanReachAirport(double budget, double timeAvailable)
        {
            return budget >= Cost && timeAvailable >= TimeRequired;
        }

        public void GoToAirport()
        {
            Console.WriteLine("Taking a cab to the airport. It's faster but more expensive. \n\n");
        }
    }
}
