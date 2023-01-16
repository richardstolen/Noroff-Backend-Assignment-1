using Back_end_Development_Assignment_1;
using Back_end_Development_Assignment_1.Heroes;

namespace Assignment1Tests.ItemTests
{
    public class WeaponTests
    {
        Weapon weapon = new Weapon("Common Axe", 2, Slot.Weapon, WeaponType.Axes, 3);

        [Fact]
        public void Name_AssertCorrectName_ShouldReturnName()
        {
            string excepted = "Common Axe";

            Assert.Equal(weapon.Name, excepted);
        }


    }
}