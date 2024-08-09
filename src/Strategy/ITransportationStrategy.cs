namespace DesignPatternsProject.Strategy
{
    public interface ITransportationStrategy
    {
        bool CanReachAirport(double budget, double timeAvailable);
        void GoToAirport();
    }
}
