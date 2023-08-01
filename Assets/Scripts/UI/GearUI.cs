using System.Text;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GearUI : MonoBehaviour
{
    [SerializeField] private Canvas canvas;

    [Header("Old Item")]
    [SerializeField] private GearSlotUI oldGearSlot;
    [SerializeField] private TextMeshProUGUI oldItemNameText;
    [SerializeField] private TextMeshProUGUI oldItemStatText;

    [Header("New Item")]
    [SerializeField] private GearSlotUI newGearSlot;
    [SerializeField] private TextMeshProUGUI newItemNameText;
    [SerializeField] private TextMeshProUGUI newItemStatText;
    [SerializeField] private Image newItemStatImage;

    [Header("Sprites")]
    [SerializeField] private Sprite topArrow;
    [SerializeField] private Sprite downArrow;

    public void OpenGear(Item oldItem, Item newItem)
    {
        canvas.gameObject.SetActive(true);

        UpdateUI(oldItem, newItem);
    }

    public void UpdateUI(Item oldItem, Item newItem)
    {
        bool ChangeArrow = true;
        if (oldItem == null)
        {
            oldGearSlot.SetSlot(oldItem, "WSH");
            oldItemNameText.color = Color.white;
            oldItemNameText.text = "Nothing";
            oldItemStatText.text = "";
            newItemStatImage.sprite = topArrow;
            ChangeArrow = false;
        }
        else
        {
            oldGearSlot.SetSlot(oldItem, "WSH");
            oldItemNameText.color = oldItem.rarity.color;
            oldItemNameText.text = GetFullItemName(oldItem);
            oldItemStatText.text = oldItem.GetStatsDescription();
        }

        newGearSlot.SetSlot(newItem, "WSH");
        newItemNameText.color = newItem.rarity.color;
        newItemNameText.text = GetFullItemName(newItem);
        newItemStatText.text = newItem.GetStatsDescription();
        if (ChangeArrow) newItemStatImage.sprite = (newItem.GetStats() > oldItem.GetStats()) ? topArrow : downArrow;
    }

    private string GetFullItemName(Item item)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append('[');
        sb.Append(item.rarity.rarityName);
        sb.Append("] ");
        sb.Append(item.itemName);
        return sb.ToString();
    }

    public void CloseGearUI()
    {
        canvas.gameObject.SetActive(false);
    }
}