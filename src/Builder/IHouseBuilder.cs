namespace DesignPatternsProject.Builder
{
    public interface IHouseBuilder
    {
        void BuildFoundation();
        void BuildWalls();
        void BuildRoof();
        void PaintHouse();
        House GetHouse();
    }
}
