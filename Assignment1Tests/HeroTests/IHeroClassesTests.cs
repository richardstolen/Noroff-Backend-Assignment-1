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
    }
}
