namespace Library;

public class Spell
{
    public Spell(string name, int attackValue)
    {
        Name = name;
        AttackValue = attackValue;
    }
    public string Name { get; set; }
    public int AttackValue { get; set; }
}