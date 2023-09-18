namespace Library;

public class Spellbook: IItem
{
    public Spellbook(string name, int defenseValue, int attackValue, List<Spell> spells)
    {
        Name = name;
        DefenseValue = defenseValue;
        AttackValue = attackValue;
        Spells = spells;
    }
    public string Name {get; set; }
    public int DefenseValue { get; set; }
    public int AttackValue{ get; set; }
    public static List<Spell> Spells { get; set; }
    public void AddSpell(Spell spell)
    {
        Spells.Add(spell);
    }
    public void RemoveSpell(Spell spell)
    {
        Spells.Remove(spell);
    }
}