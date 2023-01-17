using Back_end_Development_Assignment_1;
using Back_end_Development_Assignment_1.Heroes;
using Back_end_Development_Assignment_1.Items;
using System.Xml.Linq;

namespace Assignment1Tests.ItemTests
{
    public class ArmorTests
    {
        [Fact]
        public void Constructor_AssertCorrectName_ShouldBeEqual()
        {
            Armor armor = new Armor("Common Cloth Chest", 1, Slot.Body, ArmorType.Cloth, new ArmorAttribute(1, 1, 1));

            string expected = "Common Cloth Chest";

            Assert.Equal(armor.Name, expected);
        }

        [Fact]
        public void Constructor_AssertCorrectRequiredLevel_ShouldBeEqual()
        {
            Armor armor = new Armor("Common Cloth Chest", 2, Slot.Body, ArmorType.Cloth, new ArmorAttribute(1, 1, 1));

            int expected = 2;

            Assert.Equal(armor.RequiredLevel, expected);
        }

        [Fact]
        public void Constructor_AssertCorrectSlot_ShouldBeEqual()
        {
            Armor armor = new Armor("Common Cloth Chest", 2, Slot.Body, ArmorType.Cloth, new ArmorAttribute(1, 1, 1));

            Slot expected = Slot.Body;

            Assert.Equal(armor.Slot, expected);
        }

        [Fact]
        public void Constructor_AssertCorrectArmorType_ShouldBeEqual()
        {
            Armor armor = new Armor("Common Cloth Chest", 2, Slot.Body, ArmorType.Cloth, new ArmorAttribute(1, 1, 1));

            ArmorType expected = ArmorType.Cloth;

            Assert.Equal(armor.ArmorType, expected);
        }

        [Fact]
        public void Constructor_AssertCorrectArmorAttributes_ShouldBeEqual()
        {
            Armor armor = new Armor("Common Cloth Chest", 2, Slot.Body, ArmorType.Cloth, new ArmorAttribute(1, 2, 3));

            string expected = new ArmorAttribute(1, 2, 3).ToString();

            Assert.Equal(armor.ArmorAttribute.ToString(), expected);
        }

        [Fact]
        void ToString_AssertCorrectOutputToString_ShouldBeEqual()
        {
            Armor armor = new Armor("Common Cloth Chest", 2, Slot.Body, ArmorType.Cloth, new ArmorAttribute(1, 2, 3));

            string expected = $"{armor.Name}\n      Required Level: {armor.RequiredLevel}" + $"\n      Armor type: {armor.ArmorType}" +
                $"\n      Strength: {armor.ArmorAttribute.Strength}" +
                $"\n      Dexterity: {armor.ArmorAttribute.Dexterity}" +
                $"\n      Intelligence: {armor.ArmorAttribute.Intelligence}";

            Assert.Equal(expected, armor.ToString());
        }

        /*
         * Armor attribute test
         */

        [Fact]
        void ToString_ArmorAttributeAssertCorrectOutputToString_ShouldBeEqual()
        {
            ArmorAttribute attributes = new ArmorAttribute(1, 2, 3);

            string expected = $"Strength: {attributes.Strength}\nDexterity: {attributes.Dexterity}\nIntelligence: {attributes.Intelligence}";

            Assert.Equal(expected, attributes.ToString());
        }

    }
}