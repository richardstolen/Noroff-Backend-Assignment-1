using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back_end_Development_Assignment_1.Heroes
{
    public class Mage : Hero
    {
        public Mage(string name) : base(name)
        {
            LevelAttributes = new HeroAttribute(1, 1, 8);
            setValidArmorTypes(new List<ArmorType>() { ArmorType.Cloth });
            setValidWeaponTypes(new List<WeaponType>() { WeaponType.Staffs, WeaponType.Wands, WeaponType.Unarmed });
        }

        public override void levelUp()
        {
            base.levelUp();
            LevelAttributes.levelUp(1, 1, 5);
        }

        public override void damage()
        {
            throw new NotImplementedException();
        }






    }
}
