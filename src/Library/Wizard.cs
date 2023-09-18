namespace Library;

public class Wizard: ICharacter
{
    public Wizard(string name, int health, int attack, int defense)
    {
        Name = name;
        BaseHp = health;
        StatAttack = attack;
        StatDefense = defense;
        CurrentHp = health;
        Inventory = new List<IItem>();
    }
    public string Name {get; set; }
    public int BaseHp {get; set;}
    public int StatAttack {get; set;}
    public int StatDefense {get; set;}
    public int CurrentHp {get; set;}
    public List<IItem> Inventory{ get; set; }
    public void Attack(ICharacter character)
    {
        bool hasSpellbook = false;
        foreach(IItem i in Inventory)
        {
            if(i is Spellbook)
            {
                hasSpellbook = true;
                foreach(Spell j in Spellbook.Spells)
                {
                    character.StatAttack += j.AttackValue;
                }
            }
        }
        character.CurrentHp -= (StatAttack-character.StatDefense);
        if (character.CurrentHp > character.BaseHp)
        {
            character.CurrentHp = character.BaseHp;
        }
        if (hasSpellbook)
        {
            foreach(Spell j in Spellbook.Spells)
            {
                character.StatAttack -= j.AttackValue;
            }
        }
        
        AttackPrinter.PrintAttack(this, character);
    }
    public void Equip(IItem item)
    {
        Inventory.Add(item);
        StatAttack += item.AttackValue;
        StatDefense += item.DefenseValue;
    }
    public void Unequip(IItem item)
    {
        Inventory.Remove(item);
        StatAttack -= item.AttackValue;
        StatDefense -= item.DefenseValue;
    }
    public void ChangeItem(IItem item, IItem newItem)
    {
        Unequip(item);
        Equip(newItem);
    }
    public void Heal(ICharacter character)
    {
        character.CurrentHp = character.BaseHp;
        HealPrinter.PrintHeal(this, character);
    }
    
   
}