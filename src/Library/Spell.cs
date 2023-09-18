namespace Library;

public class Spell
{
    public Spell(string name, int attackValue)
    {
        Name = name;
        AttackValue = attackValue;
    }
    string Name { get; set; }
    int AttackValue { get; set; }
}