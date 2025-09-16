using UnityEngine;

public class Monster : MonoBehaviour
{
    //Attributes
    public string Name; //capitalization to signify that this is public
    private int hp;
    public int HP
    {
        get {return hp;}
        set {if (value <= 0) hp = 0;
            else hp = value;}

        /*get {return hp;}
        set {hp = value;}*/  //default
    }

    private int monDmg;
    public int MonDmg
    {
        get => monDmg;
        set => monDmg = value;
    }

    bool defeated;

    private int lootGold;
    public int LootGold
    {
        get => lootGold;
        set => lootGold = value;
    }

    //Constructor to create an object
    public Monster(string newName, int newHp, int gold, int monDmg) //assigning values to attributes above
    {
        Name = newName;
        HP = newHp;
        defeated = false;
        LootGold = gold;
        MonDmg = monDmg;
    }

    public void TakeDamage(int dmg)
    {
        HP -= dmg;
        Debug.Log($"{Name} took {dmg} dmg!! Current HP: {HP}");
    }

    public void Attack(Hero hero) //getting EVERYTHING from Hero.cs. Pretty cool!
    {
        hero.TakeDamage(MonDmg);
    }

    public bool IsAlive()
    {
        return (HP > 0); //if the cond is true, IsAlive will return true
    }
}
