using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back_end_Development_Assignment_1.Heroes
{
    public class Rogue : Hero
    {
        public Rogue(string name) : base(name)
        {
            LevelAttributes = new HeroAttribute(2, 6, 1);
            setValidArmorTypes(new List<ArmorType>() { ArmorType.Leather, ArmorType.Mail });
            setValidWeaponTypes(new List<WeaponType>() { WeaponType.Dagger, WeaponType.Sword, WeaponType.Unarmed });
        }

        public override void levelUp()
        {
            base.levelUp();
            LevelAttributes.levelUp(1, 4, 1);
        }
    }
}
