using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour  //monobehaviour is the biggest in terms of script heirarchy
{
    public Hero hero1; //set constructor to PUBLIC to allow access to constructor from Main
    public List<Monster> monsterPrefabs; //made to duplicate and create variables
    public List<Monster> monsters = new List<Monster>(); //variables from before that will be spawned in scene
    public Monster currentMonster;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hero1.Init("ithiban kathuga", 50, 10);
        hero1.ShowStat();

        SpawnMonster("kazuma kiryu", 50, 5, 10, 0);
        SpawnMonster("test1", 500, 2, 1, 1);
        SpawnMonster("itworks", 20, 1, 7, 2);
        /*currentMonster = Instantiate(monsterPrefabs[0]);
        currentMonster.Init("kazuma kiryu", 50, 5, 10);
        monsters.Add(currentMonster);
        currentMonster = Instantiate(monsterPrefabs[1]);
        currentMonster.Init("yay", 50, 5, 10);
        monsters.Add(currentMonster);
        currentMonster = Instantiate(monsterPrefabs[2]);
        currentMonster.Init("nauh", 50, 5, 10);
        monsters.Add(currentMonster); //storing spawned monster to the monsters list\ */

        foreach (Monster monster in monsters)
        {
            monster.ShowStat();
        }

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

    void SpawnMonster(string monster, int hp, int gold, int dmg, int index)
    {
        currentMonster = Instantiate(monsterPrefabs[index]);
        currentMonster.Init(monster, hp, gold, dmg);
        monsters.Add(currentMonster);
    }
}
