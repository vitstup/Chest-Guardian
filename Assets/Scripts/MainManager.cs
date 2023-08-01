using UnityEngine;

public class MainManager : MonoBehaviour
{
    [SerializeField] private MainUI mainUI;

    private int pointsValue;

    private void Start()
    {
        points = 0;
    }

    public int points
    {
        get { return pointsValue; }
        set
        {
            pointsValue = value;
            mainUI.SetCoinsText(pointsValue);
        }
    }
}