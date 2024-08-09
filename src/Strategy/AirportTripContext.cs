namespace DesignPatternsProject.Strategy
{
    public class AirportTripContext
    {
        private ITransportationStrategy _strategy;

        public void SetStrategy(ITransportationStrategy strategy)
        {
            _strategy = strategy;
        }

        public void GoToAirport()
        {
            _strategy?.GoToAirport();
        }

        public bool CanReachAirport(double budget, double timeAvailable)
        {
            return _strategy != null && _strategy.CanReachAirport(budget, timeAvailable);
        }
    }
}
