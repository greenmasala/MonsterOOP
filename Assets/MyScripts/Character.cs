using UnityEngine;

public abstract class Character : MonoBehaviour //abstract = cant clone/create object out of it, only used by other scripts to inherit from
{
    private string name; //capitalization to signify that this is public, not necessary but a good practice!
    public string Name
    {
        get => name;
        private set => name = string.IsNullOrEmpty(value) ? "Unknown" : value; //if name is blank, then set name to "Unknown"
    }

    protected int maxHP = 100; //protected = private but accessible to all scripts inherting from this abstract script
   
    public int HP {  get; protected set; }
    //Properties, private component that can be changed by other scripts depending on the conditions set
    /*private int hp;
    public int HP
    {
        get => hp;
        private set => hp = (value <= 0) ? 0 : value; //alternative way for if else, ternary method

        /*get {return hp;}
        set 
        {
            if (value <= 0) hp = 0;
            else hp = value;
        }
    }*/

    private int dmg;
    public int Damage
    {
        get => dmg;
        private set => dmg = (value <= 0) ? 0 : value;
    }

    //Constructor to create an object
    //Initialization: Unity doesn't use constructor, we initialize it instead BASICALLY TURNING THE CONSTRUCTOR INTO A METHOD
    public void Init(string newName, int newHp, int dmg) //virtual = when inhertied, values can be changed
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
        //HP -= dmg;
        HP = Mathf.Clamp(HP - dmg, 0, maxHP); //basically the same as the if else below, aswell as getting damaged! tho itll only apply the clamp if this method is used.
        /*if (HP < 0) HP = 0;
        else if (HP > maxHP) HP = maxHP;*/
        Debug.Log($"{Name} took {dmg} dmg!! Current HP: {HP}");
    }

    /*public virtual void Attack(Character target) //getting EVERYTHING from Character to be able to get both Hero and Monster Class. Pretty cool!
    {
        target.TakeDamage(Damage);
    }*/

    public abstract void Attack(Character target); //Abstract method = child will have to write this method themselves
    public abstract void Attack(Character target, int bonusDmg);

    public abstract void OnDefeated();

    public virtual void ShowStat()
    {
        Debug.Log($"Name: {Name} HP: {HP} Attack Power: {Damage} ");
    }
}
