namespace Library;

public class Weapon: IItem
{
    public Weapon(string name, int defenseValue, int attackValue)
    {
        Name = name;
        DefenseValue = defenseValue;
        AttackValue = attackValue;
    }
    public string Name {get; set; }
    public int DefenseValue { get; set; }
    public int AttackValue{ get; set; }
    
}