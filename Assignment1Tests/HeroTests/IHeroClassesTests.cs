using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1Tests.HeroTests
{
    public interface IHeroClassesTests
    {
        void Constructor_DefaultStrengthAttribute();
        void Constructor_DefaultDexterityAttribute();
        void Constructor_DefaultIntelligenceAttribute();
        void LevelUp_UpdatedStrengthAttribute();
        void LevelUp_UpdatedDexterityAttribute();
        void LevelUp_UpdatedIntelligenceAttribute();
        void ValidArmorTypes_CheckValidArmorTypes_ShouldBeEqual();
        void ValidWeaponTypes_CheckValidWeaponTypes_ShouldBeEqual();

    }
}
