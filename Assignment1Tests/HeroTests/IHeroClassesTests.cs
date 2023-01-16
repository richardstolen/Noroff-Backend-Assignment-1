using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1Tests.HeroTests
{
    public interface IHeroClassesTests
    {
        [Fact]
        void Constructor_DefaultStrengthAttribute();
        [Fact]
        void Constructor_DefaultDexterityAttribute();
        [Fact]
        void Constructor_DefaultIntelligenceAttribute();
        [Fact]
        void LevelUp_UpdatedStrengthAttribute();
        [Fact]
        void LevelUp_UpdatedDexterityAttribute();
        [Fact]
        void LevelUp_UpdatedIntelligenceAttribute();
        [Fact]
        void ValidWeaponTypes_CheckValidWeaponTypes_ShouldBeEqual();
        [Fact]
        void ValidWeaponTypes_CheckInValidWeaponTypes_ShouldThrowInvalidArmorException();
        [Fact]
        void ValidArmorTypes_CheckValidArmorTypes_ShouldBeEqual();
        [Fact]
        void ValidArmorTypes_CheckInValidArmorTypes_ShouldThrowInvalidArmorException();
    }
}
