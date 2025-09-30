using UnityEngine;

public class Dragon : Monster
{
    public override int LootGold => 50;

    public void InitDragon(string newName)
    {
        base.Init(newName, 50, 30);
    }

    public override void Attack(Character target)
    {
        base.Attack(target);
        Debug.Log($"{Name} attacked {target.Name} by punching them! Damage: {Damage}");
    }

    public override void OnDefeated()
    {
        throw new System.NotImplementedException();
    }

    public override void Roar()
    {
        Debug.Log($"The dragon, {Name}, roared!");
    }
}
