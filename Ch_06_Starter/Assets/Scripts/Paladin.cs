using UnityEngine;

public class Paladin : Character
{
    public Weapon PrimaryWeapon;
 
    public Paladin(string name, Weapon weapon): base(name)
    {
        this.PrimaryWeapon = weapon;
    }

    public override void PrintStatsInfo()
    {
        Debug.LogFormat("Hail {0} - take up your {1}!", this.Name, this.PrimaryWeapon.Name);
    }
}