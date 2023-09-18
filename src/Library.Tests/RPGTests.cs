namespace Library.Tests;

public class ElfAtackTests
{
    [Test]
    public void Test_Elf_Attack()
    {
        Elf elf = new Elf("uno", 10, 4, 2);
        Elf enemy = new Elf("dos", 10, 3, 1);

        elf.Attack(enemy);

        Assert.AreEqual(7, enemy.CurrentHp);
    }
    
    [Test]
    public void Test_Elf_Attack_Defensa_mayor_que_ataque()
    {
        Elf elf = new Elf("uno", 2, 3, 1);
        Elf enemy = new Elf("dos", 2, 3, 4);

        elf.Attack(enemy);

        Assert.AreEqual(2, enemy.CurrentHp);
    }
    
    [Test]
    public void Test_Elf_Heal()
    {
        Elf elf = new Elf("uno", 5, 4, 2);
        Elf enemy = new Elf("dos", 6, 3, 1);

        elf.Attack(enemy);
        elf.Heal(enemy);

        Assert.AreEqual(6, enemy.CurrentHp);
    }
    
    [Test]
    public void Test_Wizard_Attack_Spells()
    {
        Wizard wizard = new Wizard("uno", 10, 4, 2);
        Wizard enemy = new Wizard("dos", 10, 3, 1);
        Spell spell = new Spell("uno", 2);
        List<Spell> spells = new List<Spell>();
        spells.Add(spell);
        Spellbook spellbook = new Spellbook("uno", 0, 0, spells);
        spellbook.AddSpell(spell);
        wizard.Equip(spellbook);
        wizard.Attack(enemy);
        Assert.AreEqual(5, enemy.CurrentHp);
    }

    [Test]
    public void Test_AttackStat()
    {
        Dwarf dwarf = new Dwarf("Bruenor", 10, 4, 2);
        var output = new StringWriter();
        Console.SetOut(output);
        AttackStatPrinter.PrintAttackStat(dwarf);
        Assert.AreEqual($"Bruenor has 4 attack.\r\n", output.ToString());
    }
    [Test]
    public void Test_DefenseStat()
    {
        Dwarf dwarf = new Dwarf("Bruenor", 10, 4, 2);
        var output = new StringWriter();
        Console.SetOut(output);
        DefenseStatPrinter.PrintDefenseStat(dwarf);
        Assert.AreEqual($"Bruenor has 2 defense.\r\n", output.ToString());
    }

}