using UnityEngine;

public class Weapon : MonoBehaviour
{
    public string WeaponName { get; private set; }
    public int BonusDMG { get; private set; }

    public void InitWeapon(string weapon, int bonusDMG)
    {
        WeaponName = weapon;
        BonusDMG = bonusDMG;
    }
}
