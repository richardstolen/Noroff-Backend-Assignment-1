using Back_end_Development_Assignment_1;
using Back_end_Development_Assignment_1.Heroes;
using Back_end_Development_Assignment_1.Items;
using static System.Net.Mime.MediaTypeNames;

namespace Assignment1Tests
{
    public class MageHeroTests
    {
        [Fact]
        public void Assert_MageDefaultStrengthAttribute()
        {
            Mage mage = new Mage("test");

            int expectedStrength = 1;

            Assert.Equal(mage.LevelAttributes.Strength, expectedStrength);
        }
        [Fact]
        public void Assert_MageDefaultDexterityAttribute()
        {
            Mage mage = new Mage("test");

            int expectedDexterity = 1;

            Assert.Equal(mage.LevelAttributes.Dexterity, expectedDexterity);
        }
        [Fact]
        public void Assert_MageDefaultIntelligenceAttribute()
        {
            Mage mage = new Mage("test");

            int expectedIntelligence = 6;

            Assert.Equal(mage.LevelAttributes.Intelligence, expectedIntelligence);
        }

        [Fact]
        public void Assert_MageValidWeaponTypes_ShouldBeEqual()
        {
            Mage mage = new Mage("test");

            List<WeaponType> exceptedWeapons = new List<WeaponType> { WeaponType.Staffs, WeaponType.Wands };

            Assert.Equal(mage.ValidWeaponTypes, exceptedWeapons);
        }

        [Fact]
        public void equipArmor_EquipInvalidArmorType_ShouldThrowInvalidArmorException()
        {
            Mage mage = new Mage("test");

            Armor armor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Plate, new ArmorAttribute(1, 0, 0));

            Assert.Throws<InvalidArmorException>(() => mage.equipArmor(armor));
        }
    }
}