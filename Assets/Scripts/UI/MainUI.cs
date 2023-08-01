using TMPro;
using UnityEngine;

public class MainUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI coinsText;

    public void SetCoinsText(int coins)
    {
        coinsText.text = coins.ToString();
    }

}