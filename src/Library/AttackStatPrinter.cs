namespace Library;

public class AttackStatPrinter
{
    public static void PrintAttackStat(ICharacter character)
    {
        Console.WriteLine($"{character.Name} has {character.StatAttack} attack.");
    }
}