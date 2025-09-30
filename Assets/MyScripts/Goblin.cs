using UnityEngine;

public class Goblin : Monster
{
    public override int LootGold => 20;

    public void InitGoblin(string newName)
    {
        base.Init(newName, 20, 10);
    }

    public override void Attack(Character target)
    {
        base.Attack(target);
        Debug.Log($"{Name} attacked {target.Name} by kicking them! Damage: {Damage}");
    }

    public override void OnDefeated()
    {
        throw new System.NotImplementedException();
    }

    public override void Roar()
    {
        Debug.Log($"The goblin, {Name}, growled!");
    }
}
