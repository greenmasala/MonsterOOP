using UnityEngine;

public class Monster : Character
{
    bool defeated;

    private int lootGold;
    public int LootGold
    {
        get => lootGold;
        set => lootGold = value;
    }

    //Constructor to create an object
    public void Init(string newName, int newHp, int gold, int monDmg) //assigning values to attributes above
    {
        base.Init(newName, newHp, monDmg);
        defeated = false;
        LootGold = gold;
    }

   public int dropReward()
    {
        return LootGold;
    }

    public override void ShowStat()
    {
        base.ShowStat();
        Debug.Log($"Monster Bounty: {LootGold}");
    }
}
