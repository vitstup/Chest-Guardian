using UnityEngine;

[RequireComponent(typeof(IItemsHandler))]
public class CharaInventory : Inventory
{
    private IItemsHandler chara;

    [SerializeField] private InventoryUI inventoryUI;
    [SerializeField] private StatsUI statsUI;

    private void Start()
    {
        chara = GetComponent<IItemsHandler>();

        UpdateVisual();

        UpdateUI();
    }

    public override void AddItem(Item item)
    {
        base.AddItem(item);

        UpdateUI();
    }

    public override void SetHelmet(Helmet helmet)
    {
        base.SetHelmet(helmet);
        chara.SetHelmet(helmet);
    }

    public override void SetShield(Shield shield)
    {
        base.SetShield(shield);
        chara.SetShield(shield);
    }

    public override void SetWeapon(Weapon weapon)
    {
        base.SetWeapon(weapon);
        chara.SetWeapon(weapon);
    }

    private void UpdateUI()
    {
        Debug.Log("UI updated");
        if (inventoryUI != null) inventoryUI.UpdateInventory(this);
        if (statsUI != null) statsUI.UpdateInfo(this);
    }

    private void UpdateVisual()
    {
        chara.SetWeapon(weapon);
        chara.SetShield(shield);
        chara.SetHelmet(helmet);
    }
}