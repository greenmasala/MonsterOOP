using UnityEngine;

public enum MonsterType
{
    Dragon, //value = 0
    Giant,
    Orc
}

public class Monster : Character
{
    bool defeated;

    private int lootGold;
    public int LootGold
    {
        get => lootGold;
        private set => lootGold = value;
    }

    //Constructor to create an object
    public void Init(MonsterType monType) //assigning values to attributes above
    {
        switch (monType)
        {
            case MonsterType.Dragon:
                base.Init("kazuma kiryu", 50, 20);
                LootGold = 50;
                break;
            case MonsterType.Giant:
                base.Init("taiga saejima", 90, 25);
                LootGold = 35;
                break;
            case MonsterType.Orc:
                base.Init("idk anymore", 25, 10);
                LootGold = 15;
                break;
        }
        defeated = false;
    }

    /*public override void Attack(Character target)
    {
        Debug.Log($"{Name} attacked {target.Name} by punching them!");
        base.Attack(target);
    }*/

    public override void Attack(Character target)
    {
        target.TakeDamage(Damage);
        Debug.Log($"{Name} attacked {target.Name} by punching them! Damage: {Damage}");
        /*base.Attack(target);*/
    }

    public override void Attack(Character target, int bonusDmg)
    {
        int damage = Damage * 2 + (bonusDmg / 2);
        target.TakeDamage(damage);
        Debug.Log($"{Name} attacked {target.Name} by punching them! (CRITICAL HIT) Damage: {Damage}");
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
    public override void OnDefeated()
    {
        throw new System.NotImplementedException();
    }
}
