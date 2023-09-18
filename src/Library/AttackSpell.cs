namespace Library;

public class AttackSpell
{
    public AttackSpell(string name, int damage)
    {
        Name = name;
        AttackValue = damage;
    }
    public string Name { get; set; }
    public int AttackValue { get; set; }
}