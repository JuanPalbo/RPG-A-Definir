using System;
using Library;


namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Elf elf1 = new Elf("Legolas", 10, 3, 1);
            Elf elf2 = new Elf("Samantis", 10, 2, 3);
            Wizard wizard = new Wizard("Gandalf", 10, 4, 2);
            Dwarf dwarf = new Dwarf("Bruenor", 15, 2, 4);
            Weapon bow1 = new Weapon("Bow of the Galadhrim", 0, 2);
            Weapon bow2 = new Weapon("Ice Hammer", 0, 3);
            elf.Equip(bow);
            Spellbook spellbook = new Spellbook("uno", 0, 0, new List<Spell>());
            Spell spell = new Spell("Firebolt", 2);
            spellbook.AddSpell(spell);
            wizard.Equip(spellbook);
            wizard.Attack(elf);
            dwarf.Heal(elf);
            
        }
    }
}


