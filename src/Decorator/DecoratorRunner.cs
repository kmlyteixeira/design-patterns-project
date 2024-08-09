using DesignPatternsProject.Decorator;
using System;

namespace DesignPatternsProject
{
    public class DecoratorRunner
    {
        public static void RunDecoratorPattern()
        {
            IClothing clothing = new BasicClothing();

            Console.WriteLine("Basic clothing created.");
            Console.WriteLine($"Description: {clothing.GetDescription()}");
            Console.WriteLine($"Warmth level: {clothing.GetWarmth()}");

            Console.WriteLine("Would you like to add a Sweater? (yes/no)");
            if (Console.ReadLine()?.ToLower() == "yes")
            {
                clothing = new SweaterDecorator(clothing);
            }

            Console.WriteLine("Would you like to add a Jacket? (yes/no)");
            if (Console.ReadLine()?.ToLower() == "yes")
            {
                clothing = new JacketDecorator(clothing);
            }

            Console.WriteLine("Would you like to add a Raincoat? (yes/no)");
            if (Console.ReadLine()?.ToLower() == "yes")
            {
                clothing = new RaincoatDecorator(clothing);
            }

            Console.WriteLine("\nFinal clothing description and warmth:");
            Console.WriteLine($"Description: {clothing.GetDescription()}");
            Console.WriteLine($"Warmth level: {clothing.GetWarmth()}");
        }
    }
}
