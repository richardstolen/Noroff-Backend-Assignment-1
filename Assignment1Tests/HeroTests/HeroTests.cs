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
         */

        [Fact]
        void Constructor_TestCorrectName_ShouldBeEqual()
        {
            string name = "testname";
            Mage hero = new Mage(name);

            Assert.Equal(name, hero.Name);
        }

        [Fact]
        void Constructor_TestCorrectLevel_ShouldBe1()
        {
            Mage hero = new Mage("test");

            Assert.Equal((int)1, hero.Level);
        }

        [Fact]
        void LevelUp_TestCorrectLevelAfter2LevelUps_ShouldBe3()
        {
            Mage hero = new Mage("test");

            hero.levelUp();
            hero.levelUp();

            int exceptedLevel = 3;

            Assert.Equal(hero.Level, exceptedLevel);
        }

        [Fact]
        void EquipArmor_EquippingValidArmor_ShouldNotThrowException()
        {
            Mage hero = new Mage("test");

            Armor chest = new Armor("Common Cloth Chest", 1, Slot.Body, ArmorType.Cloth, new ArmorAttribute(1, 2, 0));

            var exception = Record.Exception(() => hero.equipArmor(chest));

            Assert.Null(exception);
        }

        [Fact]
        void EquipArmor_EquippingInValidArmor_ShouldThrowInvalidArmorException()
        {
            Mage hero = new Mage("test");

            Armor chest = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Plate, new ArmorAttribute(1, 2, 0));

            Assert.Throws<InvalidArmorException>(() => hero.equipArmor(chest));
        }

        [Fact]
        void EquipWeapon_EquippingValidWeapon_ShouldNotThrowException()
        {
            Mage hero = new Mage("test");

            Weapon weapon = new Weapon("Rare Staff", 1, Slot.Weapon, WeaponType.Staff, 5);

            var exception = Record.Exception(() => hero.equipWeapon(weapon));

            Assert.Null(exception);
        }

        [Fact]
        void EquipWeapon_EquippingInValidWeapon_ShouldThrowInvalidArmorException()
        {
            Mage hero = new Mage("test");

            Weapon weapon = new Weapon("Rare Sword", 1, Slot.Weapon, WeaponType.Sword, 5);

            Assert.Throws<InvalidArmorException>(() => hero.equipWeapon(weapon));
        }
    }
}

