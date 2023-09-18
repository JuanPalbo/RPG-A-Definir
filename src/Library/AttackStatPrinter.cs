namespace Library;

public class AttackStatPrinter
{
    public static void PrintAttackStat(ICharacter character)
    {
        if (character is Wizard)
        {
            int spellDmg = 0;
            foreach(IItem i in character.Inventory)
            {
                if(i is Spellbook)
                {
                    foreach(Spell j in Spellbook.Spells)
                    {
                        spellDmg += j.AttackValue;
                    }
                }
            }
            Console.WriteLine($"{character.Name} has {character.StatAttack+spellDmg} attack.");
        }
        else
        {
            Console.WriteLine($"{character.Name} has {character.StatAttack} attack.");
        }
        
    }
}