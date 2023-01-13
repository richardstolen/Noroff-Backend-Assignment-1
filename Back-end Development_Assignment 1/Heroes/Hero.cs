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
        public List<Dictionary<Slot, Item>> EquippedItems { get; set; }
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
            //EquippedItems.Add(weapon);
        }

        public void equipArmor(Armor armor)
        {
            if (armor.RequiredLevel > Level || !ValidArmorTypes.Contains(armor.ArmorType))
            {
                throw new InvalidArmorException();
            }

            foreach (var item in EquippedItems)
            {
                if (item.ContainsKey(armor.Slot))
                {
                    EquippedItems.Remove(item);
                    Dictionary<Slot, Item> newArmor = new Dictionary<Slot, Item>();
                    newArmor.Add(armor.Slot, armor);
                    EquippedItems.Add(newArmor);
                }
            }
            //EquippedItems.Add(armor);
        }

        public abstract void damage();
        public abstract void totalAttributes();
        public abstract void displayHero();
    }
}
