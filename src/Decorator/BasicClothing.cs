namespace DesignPatternsProject.Decorator
{
    public class BasicClothing : IClothing
    {
        public string GetDescription()
        {
            return "Basic clothing";
        }

        public double GetWarmth()
        {
            return 10.0; // nível de calor base
        }
    }
}
