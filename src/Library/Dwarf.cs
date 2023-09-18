namespace Library;

public class Dwarf: ICharacter
{
    public Dwarf(string name, int health, int attack, int defense)
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
        character.CurrentHp -= StatAttack;
    }
    public void Equip(IItem item)
    {
        Inventory.Add(item);
        StatAttack += item.AttackValue;
    }
    public void Unequip(IItem item)
    {
        Inventory.Remove(item);
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
    }
}