namespace DesignPatternsProject.Mediator
{
    public class AirTrafficControlTower : IAirTrafficControl
    {
        private List<Aircraft> _aircrafts = new List<Aircraft>();

        public void RegisterAircraft(Aircraft aircraft)
        {
            _aircrafts.Add(aircraft);
        }

        public void SendMessage(string message, Aircraft sender)
        {
            foreach (var aircraft in _aircrafts)
            {
                if (aircraft != sender)
                {
                    aircraft.ReceiveMessage(message);
                }
            }
        }
    }
}
