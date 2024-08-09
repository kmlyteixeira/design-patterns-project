namespace DesignPatternsProject.Builder
{
    public class HouseBuilder : IHouseBuilder
    {
        private House _house = new House();

        public void BuildFoundation()
        {
            _house.Foundation = "Concrete Foundation";
        }

        public void BuildWalls()
        {
            _house.Walls = "Brick Walls";
        }

        public void BuildRoof()
        {
            _house.Roof = "Gabled Roof";
        }

        public void PaintHouse()
        {
            _house.Paint = "White Paint";
        }

        public House GetHouse()
        {
            return _house;
        }
    }
}
