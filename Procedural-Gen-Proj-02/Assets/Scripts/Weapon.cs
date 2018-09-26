using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour
{

    public bool inPlayerInventory = false;

    private Player player;
    private WeaponComponents[] weaponsComps;
    private bool weaponUsed = false;

    public void AquireWeapon()
    {
        player = GetComponentInParent<Player>();
        weaponsComps = GetComponentsInChildren<WeaponComponents>();
    }

    void Update()
    {

    }

    public void useWeapon()
    {

    }

    public void enableSpriteRender(bool isEnabled)
    {
        foreach (WeaponComponents comp in weaponsComps)
        {
            comp.getSpriteRenderer().enabled = isEnabled;
        }
    }

    public Sprite getComponentImage(int index)
    {
        return weaponsComps[index].getSpriteRenderer().sprite;
    }
}
