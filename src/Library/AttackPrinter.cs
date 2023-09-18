namespace Library;

public class AttackPrinter
{
    public static void PrintAttack(ICharacter attacker, ICharacter defender)
    {
        Console.WriteLine($"{attacker.Name} attacks {defender.Name} for {attacker.StatAttack-defender.StatDefense} damage!");
        Console.WriteLine($"{defender.Name} has {defender.CurrentHp} health left.");
    }
}