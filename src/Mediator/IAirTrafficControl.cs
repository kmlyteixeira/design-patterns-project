namespace DesignPatternsProject.Mediator
{
    public interface IAirTrafficControl
    {
        void RegisterAircraft(Aircraft aircraft);
        void SendMessage(string message, Aircraft aircraft);
    }
}