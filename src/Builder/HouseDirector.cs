namespace DesignPatternsProject.Builder
{
    public class HouseDirector
    {
        private readonly IHouseBuilder _houseBuilder;

        public HouseDirector(IHouseBuilder houseBuilder)
        {
            _houseBuilder = houseBuilder;
        }

        public void ConstructHouse()
        {
            _houseBuilder.BuildFoundation();
            _houseBuilder.BuildWalls();
            _houseBuilder.BuildRoof();
            _houseBuilder.PaintHouse();
        }
    }
}
