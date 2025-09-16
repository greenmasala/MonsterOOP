using Unity.VisualScripting;
using UnityEngine;

public class Hero : MonoBehaviour
{
    //Attributes
    private string name; //capitalization to signify that this is public, not necessary but a good practice!
    public string Name
    {
        get => name;
        set => name = string.IsNullOrEmpty(value) ? "Unknown" : value; //if name is blank, then set name to "Unknown"
    }

    //Properties, private component that can be changed by other scripts depending on the conditions set
    private int hp;
    public int HP
    {
        get => hp; 
        set => hp = (value <= 0) ? 0 : value; //alternative way for if else, ternary method

        /*get {return hp;}
        set 
        {
            if (value <= 0) hp = 0;
            else hp = value;
        }*/
    }

    private int gold;
    public int Gold
    {
        get => gold;
        set => gold = (value <= 0) ? 0 : (value >= 999) ? 999 : value; //gold = (condition) ? if true : else

        /*get {return gold;}
        set
        {
            if (value <= 0) gold = 0;
            else if (value >= 999) gold = 999;
            else gold = value;
        }*/
    }

    private int playerDmg;
    public int PlayerDmg
    {
        get => playerDmg;
        set => playerDmg = (value <= 0) ? 0 : value;
    }

    //Constructor to create an object
    //Initialization: Unity doesn't use constructor, we initialize it instead BASICALLY TURNING THE CONSTRUCTOR INTO A METHOD
    public void Init(string newName, int newHp, int playerDmg) //assigning values to attributes above
    {
        Name = newName;
        HP = newHp;
        Gold = 0;
        PlayerDmg = playerDmg;
    }

    public bool IsAlive()
    {
        return (HP > 0); //if the cond is true, IsAlive will return true
    }

    public void EarnGold(int lootGold) //getting gold from monster (GET IN MAIN)
    {
        Gold += lootGold;
        Debug.Log($"got {Gold} gold");
    }

    public void TakeDamage(int dmg)
    {
        HP -= dmg;
        Debug.Log($"{Name} took {dmg} dmg!! Current HP: {HP}");
    }
    public void Attack(Monster monster) //getting EVERYTHING from Monster.cs. Pretty cool!
    {
        monster.TakeDamage(PlayerDmg);
    }

    public void ShowStat()
    {
        Debug.Log($"Hero name: {Name} HP: {HP} Gold: {Gold} Condition: {IsAlive()} Attack Power: {PlayerDmg} ");
    }
}
