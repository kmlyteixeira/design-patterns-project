namespace DesignPatternsProject.Strategy
{
    public class BicycleStrategy : ITransportationStrategy
    {
        private const double Cost = 0.0;
        private const double TimeRequired = 90.0;

        public bool CanReachAirport(double budget, double timeAvailable)
        {
            return budget >= Cost && timeAvailable >= TimeRequired;
        }

        public void GoToAirport()
        {
            Console.WriteLine("Riding a bicycle to the airport. It's free but slow and tiring. \n\n");
        }
    }
}
