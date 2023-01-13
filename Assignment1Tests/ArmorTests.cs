using Back_end_Development_Assignment_1;
using Back_end_Development_Assignment_1.Heroes;
using Back_end_Development_Assignment_1.Items;

namespace Assignment1Tests
{
    public class ArmorTests
    {

        Mage mage = new Mage("test");

        [Fact]
        public void Name_ShouldReturnName()
        {
            Armor armor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Plate, new ArmorAttribute(1, 0, 0));

            string expected = "Common Plate Chest";

            Assert.Equal(armor.Name, expected);
        }


    }
}