using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back_end_Development_Assignment_1
{
    public abstract class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public HeroAttribute LevelAttributes { get; set; }
        public List<Item> Items { get; set; }
        public List<WeaponType> ValidWeaponTypes { get; set; }
        public List<ArmorType> ValidArmorTypes { get; set; }

        public Hero(string name)
        {
            Name = name;
            Level = 1;
        }

        public virtual void levelUp()
        {
            Level++;
        }

        public void equipWeapon(Weapon weapon)
        {
            Items.Add(weapon);
        }

        public void equipArmor(Armor armor)
        {
            Items.Add(armor);
        }

        public abstract void damage();
        public abstract void totalAttributes();
        public abstract void displayHero();
    }
}
