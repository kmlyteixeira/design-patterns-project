using DesignPatternsProject.Factory;
using System;

namespace DesignPatternsProject
{
    public class FactoryRunner
    {
        public static void RunFactoryPattern()
        {
            Console.WriteLine("Welcome to the Vehicle Manufacturing System");
            Console.WriteLine("Please choose a vehicle type to create (car, motorcycle, truck):");
            var vehicleType = Console.ReadLine() ?? string.Empty;

            try
            {
                IVehicle vehicle = VehicleFactory.CreateVehicle(vehicleType);
                Console.WriteLine($"\n{vehicleType} created successfully.");
                vehicle.Drive();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"\nError: {ex.Message}");
            }
        }
    }
}
