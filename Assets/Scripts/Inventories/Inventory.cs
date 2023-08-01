using UnityEngine;

public class Inventory : MonoBehaviour, IItemsHandler
{
    public Weapon weapon { get; private set; }
    public Shield shield { get; private set; }
    public Helmet helmet { get; private set; }

    public virtual void AddItem(Item item)
    {
        item.AddToInventory(this);
    }

    public virtual void SetHelmet(Helmet helmet)
    {
        this.helmet = helmet;
    }

    public virtual void SetShield(Shield shield)
    {
        this.shield = shield;
    }

    public virtual void SetWeapon(Weapon weapon)
    {
        this.weapon = weapon;
    }

    public Stats GetTotalStats()
    {
        Stats stats = new Stats();
        if (weapon != null) stats += weapon.GetStats();
        if (shield != null) stats += shield.GetStats();
        if (helmet != null) stats += helmet.GetStats();
        return stats;
    }
}