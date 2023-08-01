using TMPro;
using UnityEngine;

public class StatsUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI damageText;
    [SerializeField] private TextMeshProUGUI defenseText;
    [SerializeField] private TextMeshProUGUI healthText;

    public void UpdateInfo(Inventory inventory)
    {
        var stats = inventory.GetTotalStats();
        damageText.text = "Damage " + stats.damage;
        defenseText.text = "Defense " + stats.defense;
        healthText.text = "Health " + stats.health;
    }
}