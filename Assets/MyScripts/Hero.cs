using Unity.VisualScripting;
using UnityEngine;

public class Hero : Character //change to monobehavior to inherit from abstract script character!
{
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

    //Constructor to create an object
    //Initialization: Unity doesn't use constructor, we initialize it instead BASICALLY TURNING THE CONSTRUCTOR INTO A METHOD
    /*public void Init(string newName, int newHp, int playerDmg) //assigning values to attributes above
    {
        base.Init(newName, newHp, playerDmg); //method overlaoding, call for base info from character.cs
        Gold = 0; //then add your own variable
    }*/

    public override void Init(string newName, int newHp, int dmg) //override = same name, same parameter but different assigned value
    {
        base.Init(newName, newHp, dmg);
        Gold = 0;
    }

    public void EarnGold(int lootGold) //getting gold from monster (GET IN MAIN)
    {
        Gold += lootGold;
        Debug.Log($"got {Gold} gold");
    }

    public override void ShowStat()
    {
        base.ShowStat();
        Debug.Log($"Player Gold: {Gold}");
    }
}
