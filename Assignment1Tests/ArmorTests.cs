using Back_end_Development_Assignment_1;
using Back_end_Development_Assignment_1.Heroes;
using Back_end_Development_Assignment_1.Items;

namespace Assignment1Tests
{
    public class ArmorTests
    {
        Armor armor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Plate, new ArmorAttribute(1, 0, 0));
        Mage mage = new Mage("test");

        [Fact]
        public void Name_ShouldReturnName()
        {
            string excepted = "Common Plate Chest";

            Assert.Equal(armor.Name, excepted);
        }

        [Fact]
        public void equipArmor_EquipInvalidArmorType_ShouldThrowInvalidArmorException()
        {
            Assert.Throws<InvalidArmorException>(() => mage.equipArmor(armor));
        }
    }
}