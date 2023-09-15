namespace Library;

public interface ICharacter
{
    int StatBaseHp();
    int StatCurrentHp();
    int StatAttack();
    int StatDefense();
    List<IItem> Inventory();
    public void Equip(IItem item);
    public void Unequip(IItem item);
    public void Attack(ICharacter character);
    public void Heal(ICharacter character);
}