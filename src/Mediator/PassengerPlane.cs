namespace DesignPatternsProject.Mediator
{
    public class PassengerPlane : Aircraft
    {
        public PassengerPlane(string name, IAirTrafficControl airTrafficControl) 
            : base(name, airTrafficControl) { }

        public override void ReceiveMessage(string message)
        {
            Console.WriteLine($"PassengerPlane {Name} received: {message}");
        }
    }
}
