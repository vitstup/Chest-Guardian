using System.Collections;
using UnityEngine;

public class GearManager : MonoBehaviour
{
    [SerializeField] private const int maxSameTypeItemsInRow = 3;

    [Header("Dependencies")]
    [SerializeField] private ItemsGeneratorManager generatorManager;
    [SerializeField] private Inventory inventory;
    [SerializeField] private GearUI gearUI;
    [SerializeField] private MainManager mainManager;
    [SerializeField] private DigAnimationGroup digAnimationGroup;
    [SerializeField] private PointsManager pointsManager;

    private Item currentItem;

    private Item previosItem;
    private int sameTypeItemsGetted;

    public void TryToDig()
    {
        if (currentItem == null) Dig();
        else OpenGearUI();
    }

    private void Dig()
    {
        currentItem = generatorManager.GenerateItem();
        if (previosItem != null && previosItem.GetType() == currentItem.GetType()) sameTypeItemsGetted++;
        else sameTypeItemsGetted = 1;

        if (sameTypeItemsGetted >= maxSameTypeItemsInRow)
        {
            while (true)
            {
                currentItem = generatorManager.GenerateItem();
                if (previosItem == null || previosItem.GetType() != currentItem.GetType())
                {
                    sameTypeItemsGetted = 1;
                    break;
                }
            }
        }

        StartCoroutine(DigRoutine());
    }

    private IEnumerator DigRoutine()
    {
        digAnimationGroup.RunAnimation();

        yield return new WaitUntil(() => !digAnimationGroup.IsRunning());

        OpenGearUI();
    }

    private void OpenGearUI()
    {
        gearUI.OpenGear(currentItem.GetEquipedFromInventory(inventory), currentItem);
    }

    public void DropGear()
    {
        pointsManager.CreateCoins(currentItem.GetPointsAmountAfterDropping());

        mainManager.points += currentItem.GetPointsAmountAfterDropping();

        currentItem = null;

        gearUI.CloseGearUI();

        digAnimationGroup.RunEndAnimation();
    }

    public void EquipGear()
    {
        var inventoryItem = currentItem.GetEquipedFromInventory(inventory);

        inventory.AddItem(currentItem);

        currentItem = inventoryItem;

        if (currentItem == null)
        {
            gearUI.CloseGearUI();
            digAnimationGroup.RunEndAnimation();
            return;
        }

        gearUI.UpdateUI(currentItem.GetEquipedFromInventory(inventory), currentItem);
    }
}