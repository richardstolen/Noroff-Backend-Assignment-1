using Back_end_Development_Assignment_1.Heroes;
using Back_end_Development_Assignment_1.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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

        public Hero(string name)
        {
            Name = name;
            Level = 1;
            equipNoItems();
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

        /// <summary>
        /// Equips a weapon
        /// </summary>
        /// <param name="weapon"></param>
        /// <exception cref="InvalidArmorException"></exception>
        public void equipWeapon(Weapon weapon)
        {
            try
            {
                if (weapon.RequiredLevel > Level || !ValidWeaponTypes.Contains(weapon.WeaponType))
                {
                    throw new InvalidArmorException();
                }
                foreach (var item in EquippedItems)
                {
                    if (item.ContainsKey(weapon.Slot))
                    {
                        item[weapon.Slot] = weapon;
                    }
                }
            }
            catch (InvalidArmorException e) when (weapon.RequiredLevel > Level)
            {
                throw new InvalidArmorException("Your hero level is too low for this item", e);
            }
            catch (InvalidArmorException e) when (!ValidWeaponTypes.Contains(weapon.WeaponType))
            {
                throw new InvalidArmorException("Your hero can't equip this item", e);
            }
        }


        /// <summary>
        /// Equips a new armor in the correct slot, replacing the old one
        /// </summary>
        /// <param name="armor"></param>
        /// <exception cref="InvalidArmorException"></exception>
        public void equipArmor(Armor armor)
        {
            try
            {
                if (armor.RequiredLevel > Level || !ValidArmorTypes.Contains(armor.ArmorType))
                {
                    throw new InvalidArmorException();
                }
                foreach (var item in EquippedItems)
                {
                    if (item.ContainsKey(armor.Slot))
                    {
                        item[armor.Slot] = armor;
                    }
                }
            }
            catch (InvalidArmorException) when (armor.RequiredLevel > Level)
            {
                throw new InvalidArmorException("Your hero level is too low for this item");
            }
            catch (InvalidArmorException e) when (!ValidArmorTypes.Contains(armor.ArmorType))
            {
                throw new InvalidArmorException("Your hero can't wear this item", e);
            }
        }

        /// <summary>
        /// Uses the calculate damage by getting the totalattributes from gear and calling calculateDamage method
        /// Prints out the damage to the console
        /// </summary>
        public void damage()
        {
            Weapon weapon = null;
            foreach (var dict in EquippedItems)
            {
                if (dict.TryGetValue(Slot.Weapon, out Item item))
                {
                    weapon = (Weapon)item;
                }
            }

            HeroAttribute attributes = totalAttributes();
            double damage = calculateDamage(weapon, attributes);

            Console.WriteLine($"\nYou did {damage} damage");
        }

        /// <summary>
        /// Calculates the damage a hero can do given a weapon and attributes, return 1 damage if no weapon is equipped
        /// </summary>
        /// <param name="weapon"></param>
        /// <param name="attributes"></param>
        /// <returns>double damage</returns>
        private double calculateDamage(Weapon weapon, HeroAttribute attributes)
        {
            var heroClass = Enum.Parse(typeof(HeroClasses), this.GetType().Name);

            if (weapon != null)
            {
                if (heroClass.Equals(HeroClasses.Mage))
                {
                    return weapon.WeaponDamage * (1 + (attributes.Intelligence / 100.0));
                }
                else if (heroClass.Equals(HeroClasses.Ranger))
                {
                    return weapon.WeaponDamage * (1 + (attributes.Dexterity / 100.0));
                }
                else if (heroClass.Equals(HeroClasses.Rogue))
                {
                    return weapon.WeaponDamage * (1 + (attributes.Dexterity / 100.0));
                }
                else if (heroClass.Equals(HeroClasses.Warrior))
                {
                    return weapon.WeaponDamage * (1 + (attributes.Strength / 100.0));
                }
            }

            return 1;
        }

        /// <summary>
        /// Calculates the total attributes including attributes from hero and items equipped
        /// </summary>
        /// <returns>HeroAttribute object</returns>
        public HeroAttribute totalAttributes()
        {
            HeroAttribute attributesWithArmor = LevelAttributes;

            foreach (var dict in EquippedItems)
            {
                Slot slot = dict.Keys.First();

                if (slot.Equals(Slot.Head) || slot.Equals(Slot.Body) || slot.Equals(Slot.Legs) && dict.ContainsKey(slot))
                {
                    Armor armor = (Armor)dict[slot];
                    if (armor != null)
                    {
                        attributesWithArmor.addArmorAttribute(armor.ArmorAttribute);
                    }
                }

            }
            return attributesWithArmor;
        }
        public virtual void displayHero()
        {
            HeroAttribute attributes = totalAttributes();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Name: " + Name);
            sb.AppendLine("Class: " + this.GetType().Name);
            sb.AppendLine("Level: " + Level);
            sb.AppendLine("Total Strength: " + attributes.Strength);
            sb.AppendLine("Total Dexterity: " + attributes.Dexterity);
            sb.AppendLine("Total Intelligence: " + attributes.Intelligence);
            sb.AppendLine("\nEquipped items: \n");

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
        /// Initialize the equipped item list with correct slots and with starter gear that every class can use.
        /// Used in the constructor
        /// </summary>
        public void equipItemsStarterGear()
        {
            EquippedItems = new List<Dictionary<Slot, Item>>()
            {
                new Dictionary<Slot, Item>()
                {
                    {Slot.Head, new Armor("Starter Head", 1, Slot.Head, ArmorType.Cloth, new ArmorAttribute(1, 1, 1)) }
                },
                new Dictionary<Slot, Item>()
                {
                    {Slot.Body, new Armor("Starter Chest", 1, Slot.Body, ArmorType.Cloth, new ArmorAttribute(1, 1, 1)) }
                },
                new Dictionary<Slot, Item>()
                {
                    {Slot.Legs, new Armor("Starter Legs", 1, Slot.Legs, ArmorType.Cloth, new ArmorAttribute(1, 1, 1)) }
                },
                new Dictionary<Slot, Item>()
                {
                    {Slot.Weapon, new Weapon("Starter Weapon", 1, Slot.Weapon, WeaponType.Unarmed, 1) }
                },
            };
        }

        /// <summary>
        /// Initialize the equipped item list with correct slots but with zero gear equipped.
        /// Used in the constructor
        /// </summary>
        public void equipNoItems()
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
