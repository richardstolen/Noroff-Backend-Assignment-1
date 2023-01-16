using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back_end_Development_Assignment_1.Heroes
{
    public class Warrior : Hero
    {
        public Warrior(string name) : base(name)
        {
            LevelAttributes = new HeroAttribute(5, 2, 1);
            setValidArmorTypes(new List<ArmorType>() { ArmorType.Mail, ArmorType.Plate });
            setValidWeaponTypes(new List<WeaponType>() { WeaponType.Axe, WeaponType.Hammer, WeaponType.Sword, WeaponType.Unarmed });
        }

        public override void levelUp()
        {
            base.levelUp();
            LevelAttributes.levelUp(3, 2, 1);
        }
    }
}
