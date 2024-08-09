namespace DesignPatternsProject.Strategy
{
    public class BusStrategy : ITransportationStrategy
    {
        private const double Cost = 10.0;
        private const double TimeRequired = 50.0;

        public bool CanReachAirport(double budget, double timeAvailable)
        {
            return budget >= Cost && timeAvailable >= TimeRequired;
        }

        public void GoToAirport()
        {
            Console.WriteLine("Taking the bus to the airport. It's cheap but slower. \n\n");
        }
    }
}
