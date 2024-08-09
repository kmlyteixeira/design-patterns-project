namespace DesignPatternsProject.Mediator
{
    public abstract class Aircraft
    {
        protected IAirTrafficControl _airTrafficControl;
        public string Name { get; }

        protected Aircraft(string name, IAirTrafficControl airTrafficControl)
        {
            Name = name;
            _airTrafficControl = airTrafficControl;
            _airTrafficControl.RegisterAircraft(this);
        }

        public void Send(string message)
        {
            Console.WriteLine($"{Name} sending message: {message}");
            _airTrafficControl.SendMessage(message, this);
        }

        public abstract void ReceiveMessage(string message);
    }
}
