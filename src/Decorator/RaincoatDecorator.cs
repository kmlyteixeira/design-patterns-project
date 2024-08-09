namespace DesignPatternsProject.Decorator
{
    public class RaincoatDecorator : IClothing
    {
        private readonly IClothing _clothing;

        public RaincoatDecorator(IClothing clothing)
        {
            _clothing = clothing;
        }

        public string GetDescription()
        {
            return _clothing.GetDescription() + ", Raincoat";
        }

        public double GetWarmth()
        {
            return _clothing.GetWarmth(); // o casaco impermeável não adiciona calor, apenas proteção
        }
    }
}
