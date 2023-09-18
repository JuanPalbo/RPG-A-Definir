namespace Library;

public class Armour: IItem
{
    public Armour(string name, int defenseValue, int attackValue)
    {
        Name = name;
        DefenseValue = defenseValue;
        AttackValue = attackValue;
    }
    public string Name {get; set; }
    public int DefenseValue { get; set; }
    public int AttackValue{ get; set; }
}