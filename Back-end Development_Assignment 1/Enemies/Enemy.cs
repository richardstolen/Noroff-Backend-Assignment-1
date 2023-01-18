using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back_end_Development_Assignment_1.Enemies
{
    public abstract class Enemy
    {
        public int Level { get; set; }
        public double ExperienceDrop { get; set; }
        public double Health { get; set; }
        public double Damage { get; set; }
        public string Name { get; set; }

        public Enemy(int level, double experienceDrop, double health, double damage, string name)
        {
            Level = level;
            ExperienceDrop = experienceDrop;
            Health = health;
            Damage = damage;
            Name = name;
        }

        public double attack(Hero hero)
        {
            double calculatedDamage = Damage / (1 + hero.totalAttributes().Strength / 100);

            // Critical hit 10 %
            Random random = new Random();
            int randomNumber = random.Next(100);

            if (randomNumber < 10)
            {
                Console.WriteLine("The enemy did a critical hit!");
                calculatedDamage *= 2;
            }

            return calculatedDamage;
        }
    }
}
