using UnityEngine;

public class Orc : Monster
{
    public override int LootGold => 40;

    public void InitOrc(string newName)
    {
        base.Init(newName,35, 20);
    }

    public override void Attack(Character target)
    {
        base.Attack(target);
        Debug.Log($"{Name} attacked {target.Name} by throwing them! Damage: {Damage}");
    }

    public override void OnDefeated()
    {
        throw new System.NotImplementedException();
    }

    public override void Roar()
    {
        Debug.Log($"The orc, {Name}, grunts!");
    }
}
