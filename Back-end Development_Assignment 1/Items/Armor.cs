﻿using Back_end_Development_Assignment_1.Items;

namespace Back_end_Development_Assignment_1
{
    public class Armor : Item
    {
        public ArmorType ArmorType { get; set; }
        public ArmorAttribute ArmorAttribute { get; set; }

        public Armor(string name, int requiredLevel, Slot slot, ArmorType armorType, ArmorAttribute armorAttribute) : base(name, requiredLevel, slot)
        {
            ArmorType = armorType;
            ArmorAttribute = armorAttribute;
        }

        public override string ToString()
        {
            return base.ToString() + $"\n      Armor type: {ArmorType}" +
                $"\n      Strength: {ArmorAttribute.Strength}" +
                $"\n      Dexterity: {ArmorAttribute.Dexterity}" +
                $"\n      Intelligence: {ArmorAttribute.Intelligence}";
        }
    }
}