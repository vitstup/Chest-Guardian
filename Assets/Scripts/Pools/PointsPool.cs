public class PointsPool : MonoPool<Point>
{
    public PointsPool(Point prefab, int count, bool isAutoExpanded) : base(prefab, count, isAutoExpanded)
    {

    }
}