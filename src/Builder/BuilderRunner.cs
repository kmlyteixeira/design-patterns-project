using DesignPatternsProject.Builder;
using System;

namespace DesignPatternsProject
{
    public class BuilderRunner
    {
        public static void RunBuilderPattern()
        {
            IHouseBuilder houseBuilder = new HouseBuilder();
            HouseDirector houseDirector = new HouseDirector(houseBuilder);

            Console.WriteLine("Building a small house...");

            houseDirector.ConstructHouse();
            House house = houseBuilder.GetHouse();
            
            Console.WriteLine("Construction complete. Here are the details of the house:");
            house.ShowDetails();
        }
    }
}
