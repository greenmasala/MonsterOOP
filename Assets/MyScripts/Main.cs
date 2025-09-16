using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour  //monobehaviour is the biggest in terms of script heirarchy
{
    public Hero hero1; //set constructor to PUBLIC to allow access to constructor from Main
    public List<Monster> monsterPrefabs;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hero1.Init("Test", 50, 10);
        hero1.ShowStat();
        /*hero.HP = 100;
        hero.ShowStat();
        Debug.Log($"Monster name: {monster1.Name} HP: {monster1.HP}");
        Debug.Log($"Monster name: {monster2.Name} HP: {monster2.HP}");
        Debug.Log($"Monster name: {monster3.Name} HP: {monster3.HP}");
        hero.EarnGold(monster1.LootGold);
        hero.Attack(monster1);
        hero.ShowStat();
        Debug.Log($"Monster name: {monster1.Name} HP: {monster1.HP}");
        monster3.Attack(hero);
        hero.ShowStat();*/
    }
}
