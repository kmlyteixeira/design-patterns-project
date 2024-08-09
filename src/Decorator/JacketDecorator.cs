namespace DesignPatternsProject.Decorator
{
    public class JacketDecorator : IClothing
    {
        private readonly IClothing _clothing;

        public JacketDecorator(IClothing clothing)
        {
            _clothing = clothing;
        }

        public string GetDescription()
        {
            return _clothing.GetDescription() + ", Jacket";
        }

        public double GetWarmth()
        {
            return _clothing.GetWarmth() + 20.0; // aumenta o calor
        }
    }
}
