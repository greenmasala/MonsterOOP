using Unity.VisualScripting;
using UnityEngine;

public class Hero : Character //change to monobehavior to inherit from abstract script character!
{
    public int Gold { get; private set; }
    /*private int gold;
    public int Gold
    {
        /*get => gold;
        private set => gold = (value <= 0) ? 0 : (value >= 999) ? 999 : value; //gold = (condition) ? if true : else

        /*get {return gold;}
        set
        {
            if (value <= 0) gold = 0;
            else if (value >= 999) gold = 999;
            else gold = value;
        }
    }*/

    //Constructor to create an object
    //Initialization: Unity doesn't use constructor, we initialize it instead BASICALLY TURNING THE CONSTRUCTOR INTO A METHOD
    /*public void Init(string newName, int newHp, int playerDmg) //assigning values to attributes above
    {
        base.Init(newName, newHp, playerDmg); //method overlaoding, call for base info from character.cs
        Gold = 0; //then add your own variable
    }*/

    public void Init(string newName, int newHp, int dmg) //override = same name, same parameter but different assigned value. INIT DOESNT NEED VIRTUALIZE AS WERE ALREADY INITIALIZING VALUES WITH NEWNAME, NEWHP, NEWDMG
    {
        base.Init(newName, newHp, dmg);
        Gold = 0;
    }

    public override void Attack(Character target)
    {
        target.TakeDamage(Damage);
        Debug.Log($"{Name} attacked {target.Name} using a golden bat! Damage: {Damage}");
        /*base.Attack(target);*/
    }

    public override void Attack(Character target, int bonusDmg)
    {
        int damage = Damage + bonusDmg;
        target.TakeDamage(damage);
        Debug.Log($"{Name} attacked {target.Name} using a golden bat! (CRITICAL HIT) Damage: {Damage}");
    }

    public void EarnGold(int lootGold) //getting gold from monster (GET IN MAIN)
    {
        Gold = Mathf.Clamp(Gold + lootGold, 0, 999);
        Debug.Log($"{Name} got {lootGold} gold! Current gold: {Gold}");
    }

    public void Heal(int amount)
    {
        HP = Mathf.Clamp(HP + amount, 0, maxHP);
        Debug.Log($"{Name} healed for {amount}!");
    }

    public override void ShowStat()
    {
        base.ShowStat();
        Debug.Log($"Player Gold: {Gold}");
    }
    public override void OnDefeated()
    {
        throw new System.NotImplementedException();
    }
}
