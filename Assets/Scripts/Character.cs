using UnityEngine;

public class Character : MonoBehaviour, IItemsHandler
{
    [SerializeField] private SpriteRenderer helmet;
    [SerializeField] private SpriteRenderer shield;
    [SerializeField] private SpriteRenderer weapon;

    public void SetHelmet(Helmet helmet)
    {
        if (helmet == null) this.helmet.sprite = null;
        else this.helmet.sprite = helmet.sprite;
    }

    public void SetShield(Shield shield)
    {
        if (shield == null) this.shield.sprite = null;
        else this.shield.sprite = shield.sprite;
    }

    public void SetWeapon(Weapon weapon)
    {
        if (weapon == null) this.weapon.sprite = null;
        else this.weapon.sprite = weapon.sprite;
    }
}