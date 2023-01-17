using Back_end_Development_Assignment_1.Heroes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1Tests.HeroTests
{
    public class HeroFactoryTests
    {
        [Fact]
        void Create_AssertCorrectHeroClass_ShouldBeMage()
        {
            HeroClasses hero = HeroClasses.Mage;

            HeroClasses expected = HeroClasses.Mage;

            Assert.Equal(expected.ToString(), HeroFactory.Create(hero, "testname").GetType().Name);
        }

        [Fact]
        void Create_AssertCorrectHeroClass_ShouldBeRanger()
        {
            HeroClasses hero = HeroClasses.Ranger;

            HeroClasses expected = HeroClasses.Ranger;

            Assert.Equal(expected.ToString(), HeroFactory.Create(hero, "testname").GetType().Name);
        }

        [Fact]
        void Create_AssertCorrectHeroClass_ShouldBeWarrior()
        {
            HeroClasses hero = HeroClasses.Warrior;

            HeroClasses expected = HeroClasses.Warrior;

            Assert.Equal(expected.ToString(), HeroFactory.Create(hero, "testname").GetType().Name);
        }

        [Fact]
        void Create_AssertCorrectHeroClass_ShouldBeRogue()
        {
            HeroClasses hero = HeroClasses.Rogue;

            HeroClasses expected = HeroClasses.Rogue;

            Assert.Equal(expected.ToString(), HeroFactory.Create(hero, "testname").GetType().Name);
        }
    }
}
