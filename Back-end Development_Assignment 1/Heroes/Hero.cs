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
        public List<Item> EquippedItems { get; set; }
        public List<WeaponType> ValidWeaponTypes { get; set; }
        public List<ArmorType> ValidArmorTypes { get; set; }

        public Hero() { }
        public Hero(string name)
        {
            Name = name;
            Level = 1;
        }

        public void setValidArmorTypes(List<ArmorType> armorTypes)
        {
            ValidArmorTypes = armorTypes;
        }

        public void setValidWeaponTypes(List<WeaponType> weaponTypes)
        {
            ValidWeaponTypes = weaponTypes;
        }

        public virtual void levelUp()
        {
            Level++;
        }

        public void equipWeapon(Weapon weapon)
        {
            EquippedItems.Add(weapon);
        }

        public void equipArmor(Armor armor)
        {
            EquippedItems.Add(armor);
        }

        public abstract void damage();
        public abstract void totalAttributes();
        public abstract void displayHero();
    }
}
