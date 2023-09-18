namespace Library;

public interface ICharacter
{
    string Name{ get; set; }
    int BaseHp { get; set; }
    int CurrentHp{ get; set; }
    int StatAttack{ get; set; }
    int StatDefense{ get; set; }
    List<IItem> Inventory{ get; set; }
    public void Equip(IItem item);
    public void Unequip(IItem item);
    public void ChangeItem(IItem item, IItem newItem);
    public void Attack(ICharacter character);
    public void Heal(ICharacter character);
}