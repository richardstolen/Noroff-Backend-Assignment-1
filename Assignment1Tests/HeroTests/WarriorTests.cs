using Back_end_Development_Assignment_1.Heroes;
using Back_end_Development_Assignment_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1Tests.HeroTests
{
    public class WarriorTests : IHeroClassesTests
    {
        /*
         * Tests for unique classes testing the unique default attributes and 
         * new attributes when leveling up
         * Related to Appendix C: 1) and 2)
         */

        [Fact]
        public void Constructor_DefaultStrengthAttribute()
        {
            var hero = new Warrior("test");

            int expected = 5;

            Assert.Equal(hero.LevelAttributes.Strength, expected);
        }

        [Fact]
        public void Constructor_DefaultDexterityAttribute()
        {
            var hero = new Warrior("test");

            int expected = 2;

            Assert.Equal(hero.LevelAttributes.Dexterity, expected);
        }

        [Fact]
        public void Constructor_DefaultIntelligenceAttribute()
        {
            var hero = new Warrior("test");

            int expected = 1;

            Assert.Equal(hero.LevelAttributes.Intelligence, expected);
        }

        /*
         * Tests related to check if attributes after leveling up are correct
         */

        [Fact]
        public void LevelUp_UpdatedStrengthAttribute()
        {
            var hero = new Warrior("test");

            hero.levelUp();

            int expected = 8;

            Assert.Equal(hero.LevelAttributes.Strength, expected);
        }

        [Fact]
        public void LevelUp_UpdatedDexterityAttribute()
        {
            var hero = new Warrior("test");

            hero.levelUp();

            int expected = 4;

            Assert.Equal(hero.LevelAttributes.Dexterity, expected);
        }

        [Fact]
        public void LevelUp_UpdatedIntelligenceAttribute()
        {
            var hero = new Warrior("test");

            hero.levelUp();

            int expected = 2;

            Assert.Equal(hero.LevelAttributes.Intelligence, expected);
        }

        /*
         * Tests related to checking if the hero can (or cannot) equip armor and weapons
         */

        [Fact]
        public void ValidArmorTypes_CheckValidArmorTypes_ShouldBeEqual()
        {
            var hero = new Warrior("test");

            List<ArmorType> expected = new List<ArmorType> { ArmorType.Mail, ArmorType.Plate };

            Assert.Equal(hero.ValidArmorTypes, expected);
        }

        [Fact]
        public void ValidWeaponTypes_CheckValidWeaponTypes_ShouldBeEqual()
        {
            var hero = new Warrior("test");

            List<WeaponType> expected = new List<WeaponType> { WeaponType.Axe, WeaponType.Hammer, WeaponType.Sword, WeaponType.Unarmed };

            Assert.Equal(hero.ValidWeaponTypes, expected);
        }
    }
}
