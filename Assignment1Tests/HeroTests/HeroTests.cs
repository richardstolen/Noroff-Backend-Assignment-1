using Back_end_Development_Assignment_1;
using Back_end_Development_Assignment_1.Heroes;
using Back_end_Development_Assignment_1.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;
using static System.Net.Mime.MediaTypeNames;

namespace Assignment1Tests.HeroTests
{
    public class HeroTests
    {
        /*
         * Tests that are shared between all classes, using mage class as test subject, but every class 
         * can be used.
         * Mage default attributes: str:1, dex:1, int:8
         */

        /*
        * ---------------------------------------------------------------------------------------
        * Tests related to Appendix C: 1
        * When creating a Hero, it needs to have the correct name, level and attributes
        */

        /// <summary>
        /// Testing name for new Hero class
        /// Appendix C: 1)
        /// </summary>
        [Fact]
        void Constructor_TestCorrectName_ShouldBeEqual()
        {
            string name = "testname";
            Mage hero = new Mage(name);

            Assert.Equal(name, hero.Name);
        }

        /// <summary>
        /// Testing correct level for new Hero class
        /// Appendix C: 1)
        /// </summary>
        [Fact]
        void Constructor_TestCorrectLevel_ShouldBe1()
        {
            Mage hero = new Mage("test");

            Assert.Equal((int)1, hero.Level);
        }

        /// <summary>
        /// Testing correct level after two level ups for new Hero class
        /// Appendix C: 2)
        /// </summary>
        [Fact]
        void LevelUp_TestCorrectLevelAfter2LevelUps_ShouldBe3()
        {
            Mage hero = new Mage("test");

            hero.levelUp();
            hero.levelUp();

            int exceptedLevel = 3;

            Assert.Equal(hero.Level, exceptedLevel);
        }

        /// <summary>
        /// Testing that a hero can equip valid armor
        /// Appendix C: 6)
        /// </summary>
        [Fact]
        void EquipArmor_EquippingValidArmor_ShouldNotThrowException()
        {
            Mage hero = new Mage("test");

            Armor chest = new Armor("Common Cloth Chest", 1, Slot.Body, ArmorType.Cloth, new ArmorAttribute(1, 2, 0));

            var exception = Record.Exception(() => hero.equipArmor(chest));

            Assert.Null(exception);
        }

        /// <summary>
        /// Testing that a hero can't equip invalid armor
        /// Appendix C: 6)
        /// </summary>
        [Fact]
        void EquipArmor_EquippingInValidArmor_ShouldThrowInvalidArmorException()
        {
            Mage hero = new Mage("test");

            Armor chest = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Plate, new ArmorAttribute(1, 2, 0));

            Assert.Throws<InvalidArmorException>(() => hero.equipArmor(chest));
        }

        /// <summary>
        /// Testing that a hero can equip valid weapon
        /// Appendix C: 5)
        /// </summary>
        [Fact]
        void EquipWeapon_EquippingValidWeapon_ShouldNotThrowException()
        {
            Mage hero = new Mage("test");

            Weapon weapon = new Weapon("Rare Staff", 1, Slot.Weapon, WeaponType.Staff, 5);

            var exception = Record.Exception(() => hero.equipWeapon(weapon));

            Assert.Null(exception);
        }

        /// <summary>
        /// Testing that a hero can't equip invalid weapon
        /// Appendix C: 5)
        /// </summary>
        [Fact]
        void EquipWeapon_EquippingInValidWeapon_ShouldThrowInvalidArmorException()
        {
            Mage hero = new Mage("test");

            Weapon weapon = new Weapon("Rare Sword", 1, Slot.Weapon, WeaponType.Sword, 5);

            Assert.Throws<InvalidArmorException>(() => hero.equipWeapon(weapon));
        }


        /*
         * ---------------------------------------------------------------------------------------
         * Tests related to Appendix C: 7
         * Checking if total attributes are calculated correctly with different types of equipment
         * and equipment swapping.
         */

        /// <summary>
        /// Test related to Appendix C: 7.1
        /// </summary>
        [Fact]
        void TotalAttributes_CalculatingTotalAttributesWithNoEquipment_ShouldBeEqual()
        {
            var hero = new Mage("test");

            HeroAttribute expected = new HeroAttribute(1, 1, 8);

            Assert.Equal(expected.ToString(), hero.totalAttributes().ToString());
        }

        /// <summary>
        /// Test related to Appendix C: 7.2
        /// </summary>
        [Fact]
        void TotalAttributes_CalculatingTotalAttributesWithOneArmor_ShouldBeEqual()
        {
            var hero = new Mage("test");

            Armor armor = new Armor("Common Cloth Chest", 1, Slot.Body, ArmorType.Cloth, new ArmorAttribute(2, 2, 2));

            hero.equipArmor(armor);

            HeroAttribute expected = new HeroAttribute(3, 3, 10);

            Assert.Equal(expected.ToString(), hero.totalAttributes().ToString());
        }

        /// <summary>
        /// Test related to Appendix C: 7.3
        /// </summary>
        [Fact]
        void TotalAttributes_CalculatingTotalAttributesWithTwoArmor_ShouldBeEqual()
        {
            var hero = new Mage("test");

            Armor chest = new Armor("Common Cloth Chest", 1, Slot.Body, ArmorType.Cloth, new ArmorAttribute(2, 2, 2));
            Armor legs = new Armor("Common Cloth Legs", 1, Slot.Legs, ArmorType.Cloth, new ArmorAttribute(2, 2, 2));

            hero.equipArmor(chest);
            hero.equipArmor(legs);

            HeroAttribute expected = new HeroAttribute(5, 5, 12);

            Assert.Equal(expected.ToString(), hero.totalAttributes().ToString());
        }

        /// <summary>
        /// Test related to Appendix C: 7.4
        /// </summary>
        [Fact]
        void TotalAttributes_CalculatingTotalAttributesWithReplacingArmor_ShouldBeEqual()
        {
            var hero = new Mage("test");

            Armor commonChest = new Armor("Common Cloth Chest", 1, Slot.Body, ArmorType.Cloth, new ArmorAttribute(2, 2, 2));
            Armor legendaryChest = new Armor("Legendary Cloth Chest", 1, Slot.Body, ArmorType.Cloth, new ArmorAttribute(4, 4, 4));

            hero.equipArmor(commonChest);
            hero.equipArmor(legendaryChest);

            HeroAttribute expected = new HeroAttribute(5, 5, 12);

            Assert.Equal(expected.ToString(), hero.totalAttributes().ToString());
        }
    }
}

