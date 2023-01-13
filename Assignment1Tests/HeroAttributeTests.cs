using Back_end_Development_Assignment_1;
using Back_end_Development_Assignment_1.Heroes;

namespace Assignment1Tests
{
    public class HeroAttributeTests
    {
        [Fact]
        public void Assert_MageDefaultAttributes()
        {
            Mage mage = new Mage();

            int expectedStrength = 1;
            int expectedDexterity = 1;
            int expectedIntelligence = 6;

            Assert.Equal(mage.LevelAttributes.Strength, expectedStrength);
            Assert.Equal(mage.LevelAttributes.Dexterity, expectedDexterity);
            Assert.Equal(mage.LevelAttributes.Intelligence, expectedIntelligence);
        }
    }
}