namespace DesignPatternsProject.Mediator
{
    public class CargoPlane : Aircraft
    {
        public CargoPlane(string name, IAirTrafficControl airTrafficControl) 
            : base(name, airTrafficControl) { }

        public override void ReceiveMessage(string message)
        {
            Console.WriteLine($"CargoPlane {Name} received: {message}");
        }
    }
}
