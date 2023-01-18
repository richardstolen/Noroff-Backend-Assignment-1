using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back_end_Development_Assignment_1.Heroes
{
    public class HeroFactory
    {
        /// <summary>
        /// A static method to create a hero from a string that corresponds to a hero
        /// </summary>
        /// <param name="heroClass"></param>
        /// <param name="name"></param>
        /// <returns></returns>
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





