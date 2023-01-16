using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back_end_Development_Assignment_1.Heroes
{
    public class HeroFactory
    {
        public enum Classes
        {
            Mage,
            Ranger,
            Rogue,
            Warrior
        }

        public static Hero Create(Classes heroClass, string name)
        {
            if (heroClass == Classes.Mage)
            {
                return new Mage(name);
            }
            else if (heroClass == Classes.Ranger)
            {
                return new Ranger(name);
            }
            else
            {
                return new Mage(name);
            }
        }
    }


}

