namespace DesignPatternsProject.Builder
{
    public class House
    {
        public string Foundation { get; set; }
        public string Walls { get; set; }
        public string Roof { get; set; }
        public string Paint { get; set; }

        public void ShowDetails()
        {
            Console.WriteLine("House Details:");
            Console.WriteLine($"Foundation: {Foundation}");
            Console.WriteLine($"Walls: {Walls}");
            Console.WriteLine($"Roof: {Roof}");
            Console.WriteLine($"Paint: {Paint}");
        }
    }
}
