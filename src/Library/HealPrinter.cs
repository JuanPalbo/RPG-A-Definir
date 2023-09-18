namespace Library;

public class HealPrinter
{
    public static void PrintHeal(ICharacter healer, ICharacter healed)
    {
        Console.WriteLine($"{healer.Name} heals {healed.Name}!");
        Console.WriteLine($"{healed.Name} has {healed.CurrentHp} health.");
    }
}