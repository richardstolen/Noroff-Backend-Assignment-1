using Back_end_Development_Assignment_1;
using Back_end_Development_Assignment_1.Heroes;

namespace Assignment1Tests.ItemTests
{
    public class WeaponTests
    {

        [Fact]
        public void Constructor_AssertCorrectName_ShouldBeEqual()
        {
            Weapon weapon = new Weapon("Common Axe", 2, Slot.Weapon, WeaponType.Axe, 3);

            string expected = "Common Axe";

            Assert.Equal(weapon.Name, expected);
        }

        [Fact]
        public void Constructor_AssertCorrectRequiredLevel_ShouldBeEqual()
        {
            Weapon weapon = new Weapon("Common Axe", 2, Slot.Weapon, WeaponType.Axe, 3);

            int expected = 2;

            Assert.Equal(weapon.RequiredLevel, expected);
        }

        [Fact]
        public void Constructor_AssertCorrectSlot_ShouldBeEqual()
        {
            Weapon weapon = new Weapon("Common Axe", 2, Slot.Weapon, WeaponType.Axe, 3);

            Slot expected = Slot.Weapon;

            Assert.Equal(weapon.Slot, expected);
        }

        [Fact]
        public void Constructor_AssertCorrectWeaponType_ShouldBeEqual()
        {
            Weapon weapon = new Weapon("Common Axe", 2, Slot.Weapon, WeaponType.Axe, 3);

            WeaponType expected = WeaponType.Axe;

            Assert.Equal(weapon.WeaponType, expected);
        }

        [Fact]
        public void Constructor_AssertCorrectWeaponDamage_ShouldBeEqual()
        {
            Weapon weapon = new Weapon("Common Axe", 2, Slot.Weapon, WeaponType.Axe, 3);

            int expected = 3;

            Assert.Equal(weapon.WeaponDamage, expected);
        }
    }
}