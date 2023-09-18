namespace Library;

public class Spellbook: IItem
{
    public Spellbook(string name, int defenseValue, int attackValue, List<ISpell> spells)
    {
        Name = name;
        DefenseValue = defenseValue;
        AttackValue = attackValue;
        Spells = spells;
    }
    public string Name {get; set; }
    public int DefenseValue { get; set; }
    public int AttackValue{ get; set; }
    public List<ISpell> Spells { get; set; }
    public void AddSpell(ISpell spell)
    {
        Spells.Add(spell);
    }
    public void RemoveSpell(ISpell spell)
    {
        Spells.Remove(spell);
    }
}