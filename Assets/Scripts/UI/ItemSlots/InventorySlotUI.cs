using UnityEngine;
using UnityEngine.UI;

public class InventorySlotUI : MonoBehaviour
{
    [SerializeField] private Image backgroundImage;
    [SerializeField] private Image itemImage;
    [SerializeField] private GameObject alternativeImage;

    protected Color baseBgColor;

    protected virtual void Start()
    {
        baseBgColor = backgroundImage.color;
    }

    public void SetSlot(Item item)
    {
        if (item == null)
        {
            backgroundImage.color = baseBgColor;
            itemImage.enabled = false;
            alternativeImage.SetActive(true);
        }
        else
        {
            backgroundImage.color = item.rarity.color;
            itemImage.enabled = true;
            itemImage.sprite = item.sprite;
            alternativeImage.SetActive(false);
        }
    }
}