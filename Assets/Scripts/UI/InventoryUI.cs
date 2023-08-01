using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    [SerializeField] private InventorySlotUI weaponSlot;
    [SerializeField] private InventorySlotUI shieldSlot;
    [SerializeField] private InventorySlotUI helmetSlot;

    public void UpdateInventory(Inventory inventory)
    {
        weaponSlot.SetSlot(inventory.weapon);
        shieldSlot.SetSlot(inventory.shield);
        helmetSlot.SetSlot(inventory.helmet);
    }
}