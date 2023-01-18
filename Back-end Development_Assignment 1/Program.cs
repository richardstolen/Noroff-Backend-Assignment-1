using Back_end_Development_Assignment_1.Heroes;
using Back_end_Development_Assignment_1.Items;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back_end_Development_Assignment_1
{
    internal class Program
    {
        [ExcludeFromCodeCoverage]
        static void Main(string[] args)
        {
            Weapon weapon = new Weapon("Common Axe", 1, Slot.Weapon, WeaponType.Axe, 2);
            Armor armor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Plate, new ArmorAttribute(1, 0, 0));

            Warrior hero = new Warrior("Bob");

            double damageNoWeapon = hero.damage();

            hero.equipWeapon(weapon);

            double damageWithWeapon = hero.damage();

            hero.equipArmor(armor);

            double damageWithWeaponAndArmor = hero.damage();

            Console.WriteLine($"Damage with no weapon: {damageNoWeapon}" +
                $"\nDamage with a weapon: {damageWithWeapon}" +
                $"\nDamage with weapon and armor: {damageWithWeaponAndArmor}");
            Console.WriteLine(new string('*', 50));

            hero.displayHero();

        }
    }
}
