using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back_end_Development_Assignment_1.Heroes
{
    public class HeroFactory
    {
        public static Hero Create(HeroClasses heroClass, string name)
        {
            if (heroClass == HeroClasses.Mage)
            {
                return new Mage(name);
            }
            else if (heroClass == HeroClasses.Ranger)
            {
                return new Ranger(name);
            }
            else if (heroClass == HeroClasses.Rogue)
            {
                return new Rogue(name);
            }
            else

                return new Warrior(name);
        }
    }
}





