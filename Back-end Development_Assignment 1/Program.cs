using Back_end_Development_Assignment_1.Heroes;
using Back_end_Development_Assignment_1.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back_end_Development_Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mage mage = new Mage("name");
            Weapon weapon = new Weapon("Rare Staff", 1, Slot.Weapon, WeaponType.Staffs, 5);
            Armor chest = new Armor("Common Cloth Chest", 1, Slot.Body, ArmorType.Cloth, new ArmorAttribute(1, 2, 0));
            mage.equipArmor(chest);
            Armor legs = new Armor("Common Cloth Legs", 1, Slot.Legs, ArmorType.Cloth, new ArmorAttribute(1, 5, 0));
            mage.equipArmor(legs);
            Hero hero = mage;



            Armor armor2 = new Armor("Rare Cloth Chest", 1, Slot.Body, ArmorType.Cloth, new ArmorAttribute(1, 0, 6));
            //mage.equipArmor(armor2);
            //Console.WriteLine(mage);
            //Console.ReadLine();
            mage.equipWeapon(weapon);
            mage.displayHero();

            mage.damage();


        }
    }
}
