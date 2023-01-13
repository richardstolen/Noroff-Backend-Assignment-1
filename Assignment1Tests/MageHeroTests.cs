using Back_end_Development_Assignment_1;
using Back_end_Development_Assignment_1.Heroes;

namespace Assignment1Tests
{
    public class MageHeroTests
    {
        [Fact]
        public void Assert_MageDefaultAttributes()
        {
            Mage mage = new Mage("test");

            int expectedStrength = 1;
            int expectedDexterity = 1;
            int expectedIntelligence = 6;

            Assert.Equal(mage.LevelAttributes.Strength, expectedStrength);
            Assert.Equal(mage.LevelAttributes.Dexterity, expectedDexterity);
            Assert.Equal(mage.LevelAttributes.Intelligence, expectedIntelligence);
        }

        [Fact]
        public void Assert_MageValidWeaponTypes()
        {
            Mage mage = new Mage("test");

            List<WeaponType> exceptedWeapons = new List<WeaponType> { WeaponType.Staffs, WeaponType.Wands };

            Assert.Equal(mage.ValidWeaponTypes, exceptedWeapons);
        }
    }
}