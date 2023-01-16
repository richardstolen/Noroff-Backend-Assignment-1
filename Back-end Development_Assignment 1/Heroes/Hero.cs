using Back_end_Development_Assignment_1.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
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
            equippedItemsInit();
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


        /// <summary>
        /// 
        /// </summary>
        /// <param name="armor"></param>
        /// <exception cref="InvalidArmorException"></exception>
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
                    //EquippedItems.Remove(item);
                    //Dictionary<Slot, Item> newArmor = new Dictionary<Slot, Item>();
                    //newArmor.Add(armor.Slot, armor);
                    //EquippedItems.Add(newArmor);
                    item[armor.Slot] = armor;
                }
            }

        }

        public abstract void damage();
        public void totalAttributes()
        {
            HeroAttribute temp = LevelAttributes;

            foreach (var dict in EquippedItems)
            {
                Slot slot = dict.Keys.First();
                Console.WriteLine(slot.ToString());

                //if (slot.Equals(Slot.Head) || slot.Equals(Slot.Body) || slot.Equals(Slot.Legs))
                //{


                //    Armor armor = (Armor)dict[slot];
                //    Console.WriteLine(armor.ToString());
                //}

                if (dict.ContainsKey(Slot.Head))
                {
                    //Armor headArmor = (Armor)dict[Slot.Head];
                    //temp.addArmorAttribute(headArmor.ArmorAttribute);

                }

                if (dict.ContainsKey(Slot.Body))
                {
                    Armor bodyArmor = (Armor)dict[Slot.Body];
                    temp.addArmorAttribute(bodyArmor.ArmorAttribute);
                }

                if (dict.ContainsKey(Slot.Legs))
                {
                    Armor legArmor = (Armor)dict[Slot.Legs];
                    temp.addArmorAttribute(legArmor.ArmorAttribute);
                }
            }
            Console.WriteLine(temp.ToString());
        }
        public virtual void displayHero()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Name: " + Name);
            sb.AppendLine("Class: " + this.GetType().Name);
            sb.AppendLine("Level: " + Level);
            sb.AppendLine("Total Strength: " + LevelAttributes.Strength);
            sb.AppendLine("Total Dexterity: " + LevelAttributes.Dexterity);
            sb.AppendLine("Total Intelligence: " + LevelAttributes.Intelligence);
            sb.AppendLine("Equipped items: \n");

            foreach (var dict in EquippedItems)
            {
                foreach (var item in dict)
                {
                    sb.AppendLine($"    Slot: {item.Key}\n      Item: {item.Value}\n");
                }
            }

            Console.WriteLine(sb);
        }



        /// <summary>
        /// Initialize the equipped item list with correct slots but without any armor or weapon
        /// Used in the constructor
        /// </summary>
        public void equippedItemsInit()
        {
            EquippedItems = new List<Dictionary<Slot, Item>>()
            {
                new Dictionary<Slot, Item>()
                {
                    {Slot.Head, null }
                },
                new Dictionary<Slot, Item>()
                {
                    {Slot.Body, null }
                },
                new Dictionary<Slot, Item>()
                {
                    {Slot.Legs, null }
                },
                new Dictionary<Slot, Item>()
                {
                    {Slot.Weapon, null }
                },
            };
        }
    }
}
