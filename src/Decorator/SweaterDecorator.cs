namespace DesignPatternsProject.Decorator
{
    public class SweaterDecorator : IClothing
    {
        private readonly IClothing _clothing;

        public SweaterDecorator(IClothing clothing)
        {
            _clothing = clothing;
        }

        public string GetDescription()
        {
            return _clothing.GetDescription() + ", Sweater";
        }

        public double GetWarmth()
        {
            return _clothing.GetWarmth() + 15.0; // aumenta o calor
        }
    }
}
