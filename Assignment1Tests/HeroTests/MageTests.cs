using Back_end_Development_Assignment_1;
using Back_end_Development_Assignment_1.Heroes;
using Back_end_Development_Assignment_1.Items;
using static System.Net.Mime.MediaTypeNames;

namespace Assignment1Tests.HeroTests
{
    public class MageTests
    {
        /*
         * Tests related to the default attributes when creating a hero
         */



        [Fact]
        public void Constructor_DefaultStrengthAttribute()
        {
            Mage mage = new Mage("test");

            int expected = 1;

            Assert.Equal(mage.LevelAttributes.Strength, expected);
        }

        [Fact]
        public void Constructor_DefaultDexterityAttribute()
        {
            Mage mage = new Mage("test");

            int expected = 1;

            Assert.Equal(mage.LevelAttributes.Dexterity, expected);
        }

        [Fact]
        public void Constructor_DefaultIntelligenceAttribute()
        {
            Mage mage = new Mage("test");

            int expected = 8;

            Assert.Equal(mage.LevelAttributes.Intelligence, expected);
        }

        /*
         * Tests related to check if attributes after leveling up are correct
         */

        [Fact]
        public void LevelUp_UpdatedStrengthAttribute()
        {
            Mage mage = new Mage("test");

            mage.levelUp();

            int expected = 2;

            Assert.Equal(mage.LevelAttributes.Strength, expected);
        }


        [Fact]
        public void ValidWeaponTypes_CheckValidWeaponTypes_ShouldBeEqual()
        {
            Mage mage = new Mage("test");

            List<WeaponType> exceptedWeapons = new List<WeaponType> { WeaponType.Staff, WeaponType.Wand, WeaponType.Unarmed };

            Assert.Equal(mage.ValidWeaponTypes, exceptedWeapons);
        }




        /*
         * Tests related to checking if the hero can (or cannot) equip armor and weapons
         */

        [Fact]
        public void equipArmor_EquipInvalidArmorType_ShouldThrowInvalidArmorException()
        {
            Mage mage = new Mage("test");

            Armor armor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Plate, new ArmorAttribute(1, 0, 0));

            Assert.Throws<InvalidArmorException>(() => mage.equipArmor(armor));
        }


    }
}