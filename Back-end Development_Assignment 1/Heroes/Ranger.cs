using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back_end_Development_Assignment_1.Heroes
{
    public class Ranger : Hero
    {
        public Ranger(string name) : base(name)
        {
            LevelAttributes = new HeroAttribute(1, 7, 1);
            setValidArmorTypes(new List<ArmorType>() { ArmorType.Leather, ArmorType.Mail });
            setValidWeaponTypes(new List<WeaponType>() { WeaponType.Bow, WeaponType.Unarmed });
        }

        public override void levelUp()
        {
            base.levelUp();
            LevelAttributes.levelUp(1, 5, 1);
        }
    }
}
