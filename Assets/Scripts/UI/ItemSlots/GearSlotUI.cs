using TMPro;
using UnityEngine;

public class GearSlotUI : InventorySlotUI
{
    [SerializeField] private TextMeshProUGUI alternativeText;
    [SerializeField] private Color baseColor;

    protected override void Start()
    {
        baseBgColor = baseColor;
    }

    public void SetSlot(Item item, string alternative)
    {
        SetSlot(item);
        alternativeText.text = alternative;
    }
}