using DesignPatternsProject.Strategy;

namespace DesignPatternsProject
{
    public class StrategyRunner
    {
        public static void RunStrategyPattern()
        {
            var tripContext = new AirportTripContext();
            var strategies = new List<ITransportationStrategy>
            {
                new BusStrategy(),
                new CarStrategy(),
                new BicycleStrategy()
            };

            Console.WriteLine("\n\nEnter your available time to get to the airport (in minutes):");
            double timeAvailable = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nEnter your budget to get to the airport:");
            double budget = Convert.ToDouble(Console.ReadLine());

            foreach (var strategy in strategies)
            {
                if (strategy.CanReachAirport(budget, timeAvailable))
                {
                    tripContext.SetStrategy(strategy);
                    break;
                }
            }

            if (tripContext.CanReachAirport(budget, timeAvailable))
            {
                tripContext.GoToAirport();
            }
            else
            {
                Console.WriteLine("\nSorry! No suitable transportation option available within your budget and time constraints :( \n\n");
            }
        }
    }
}