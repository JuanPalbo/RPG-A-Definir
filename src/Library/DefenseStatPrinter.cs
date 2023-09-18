namespace Library;

public class DefenseStatPrinter
{
    public static void PrintDefenseStat(ICharacter character)
    {
        Console.WriteLine($"{character.Name} has {character.StatDefense} defense.");
    }
}