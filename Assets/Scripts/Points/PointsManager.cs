using UnityEngine;

public class PointsManager : MonoBehaviour
{
    [SerializeField] private Point prefab;
    [SerializeField] private Transform chara;
    [SerializeField] private Transform pointsCounter;

    private PointsPool pool;

    private void Start()
    {
        pool = new PointsPool(prefab, 5, true);
    }

    public void CreateCoins(int coinsAmount)
    {
        for (int i = 0; i < coinsAmount; i++)
        {
            var point = pool.GetElement();
            point.InitializePoint(chara.position, pointsCounter.position);
        }
    }
}