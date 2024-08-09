namespace DesignPatternsProject.Factory
{
    public static class VehicleFactory
    {
        public static IVehicle CreateVehicle(string vehicleType)
        {
            return vehicleType.ToLower() switch
            {
                "car" => new Car(),
                "motorcycle" => new Motorcycle(),
                "truck" => new Truck(),
                _ => throw new ArgumentException("Invalid vehicle type")
            };
        }
    }
}
