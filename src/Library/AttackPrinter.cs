namespace Library;

public class AttackPrinter
{
    public static void PrintAttack(ICharacter attacker, ICharacter defender)
    {
          if (attacker is Wizard)
        {
            int spellDmg = 0;
            foreach(IItem i in attacker.Inventory)
            {
                if(i is Spellbook)
                {
                    foreach(Spell j in Spellbook.Spells)
                    {
                        spellDmg += j.AttackValue;
                    }
                }
            }
            Console.WriteLine($"{attacker.Name} attacks {defender.Name} for {attacker.StatAttack+spellDmg-defender.StatDefense} damage!");
            Console.WriteLine($"{defender.Name} has {defender.CurrentHp} health left.");
        }
        else
        {
            Console.WriteLine($"{attacker.Name} attacks {defender.Name} for {attacker.StatAttack-defender.StatDefense} damage!");
            Console.WriteLine($"{defender.Name} has {defender.CurrentHp} health left.");;
        }

    }
}