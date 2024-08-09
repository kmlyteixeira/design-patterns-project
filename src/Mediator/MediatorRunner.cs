using DesignPatternsProject.Mediator;
using System;

namespace DesignPatternsProject
{
    public class MediatorRunner
    {
        public static void RunMediatorPattern()
        {
            var airTrafficControl = new AirTrafficControlTower();

            Console.WriteLine("Welcome to the Air Traffic Control System");

            Console.WriteLine("Please select the type of plane (passenger or cargo):");
            string planeType = Console.ReadLine()?.ToLower() ?? string.Empty;

            Console.WriteLine($"Enter the {(planeType == "passenger" ? "Flight" : "Cargo")} number:");
            var number = Console.ReadLine();

            string callSign = planeType == "passenger" ? $"Flight {number}" : $"Cargo {number}";

            Aircraft aircraft;

            if (planeType == "passenger")
            {
                aircraft = new PassengerPlane(callSign, airTrafficControl);
            }
            else if (planeType == "cargo")
            {
                aircraft = new CargoPlane(callSign, airTrafficControl);
            }
            else
            {
                Console.WriteLine("Invalid plane type selected.");
                return;
            }

            Console.WriteLine("Enter the message to send to the control tower:");
            var message = Console.ReadLine() ?? string.Empty;

            aircraft.Send(message);
        }
    }
}
