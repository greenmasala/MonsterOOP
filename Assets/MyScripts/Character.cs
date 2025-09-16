using UnityEngine;

public abstract class Character : MonoBehaviour //abstract = cant clone/create object out of it, only used by other scripts to inherit from
{
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

    private int dmg;
    public int Damage
    {
        get => dmg;
        set => dmg = (value <= 0) ? 0 : value;
    }

    //Constructor to create an object
    //Initialization: Unity doesn't use constructor, we initialize it instead BASICALLY TURNING THE CONSTRUCTOR INTO A METHOD
    public virtual void Init(string newName, int newHp, int dmg) //virtual = when inhertied, values can be changed
    {
        Name = newName;
        HP = newHp;
        Damage = dmg;
    }

    public bool IsAlive()
    {
        return (HP > 0); //if the cond is true, IsAlive will return true
    }

    public void TakeDamage(int dmg)
    {
        HP -= dmg;
        Debug.Log($"{Name} took {dmg} dmg!! Current HP: {HP}");
    }
    public void Attack(Monster monster) //getting EVERYTHING from Monster.cs. Pretty cool!
    {
        monster.TakeDamage(Damage);
    }

    public virtual void ShowStat()
    {
        Debug.Log($"Name: {Name} HP: {HP} Attack Power: {Damage} ");
    }
}
