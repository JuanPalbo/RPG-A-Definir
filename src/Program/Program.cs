using System;
using Library;


namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Elf elf = new Elf("Legolas", 10, 3, 1);
            Wizard wizard = new Wizard("Gandalf", 10, 4, 2);
            Dwarf dwarf = new Dwarf("Bruenor", 15, 2, 4);
            Spellbook spellbook = new Spellbook("uno", 0, 0, new List<Spell>());
            Spell spell = new Spell("Firebolt", 2);
            spellbook.AddSpell(spell);
            wizard.Equip(spellbook);
            wizard.Attack(elf);
            dwarf.Heal(elf);
            
        }
    }
}


