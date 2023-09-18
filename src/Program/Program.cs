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
            Wizard wizard2 = new Wizard("Karsus", 9, 4, 3);
            Dwarf dwarf = new Dwarf("Bruenor", 15, 2, 4);
            Dwarf dwarf2 = new Dwarf("Elvis", 12, 2, 2);
            
            Weapon bow = new Weapon("Bow of the Galadhrim", 0, 2);
            Weapon hammer = new Weapon("Ice Hammer", 0, 3);
            
            Armour armour = new Armour("Chain Shirt", 1, 0);
            Armour armour2 = new Armour("Breastplate", 2, 0);
            
            Spellbook spellbook = new Spellbook("Gandalfspellbook", 0, 0, new List<Spell>());
            Spellbook spellbook2 = new Spellbook("Karsusspellbook", 0, 0, new List<Spell>());
            
            Spell spell = new Spell("Firebolt", 2);
            Spell spell2 = new Spell("Thunderbolt", 2);
            spellbook.AddSpell(spell);
            spellbook2.AddSpell(spell2);
            
            elf1.Equip(armour);
            wizard.Equip(spellbook);
            wizard2.Equip(spellbook2);
            elf2.Equip(hammer);
            
            wizard.Attack(elf1);
            dwarf.Heal(elf1);
            wizard2.Attack(dwarf2);
            elf1.Attack(wizard2);

        }
    }
}


