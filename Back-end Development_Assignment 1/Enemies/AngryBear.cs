using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back_end_Development_Assignment_1.Enemies
{
    public class AngryBear : Enemy
    {
        public AngryBear(int level, double experienceDrop, double health, double damage, string name) : base(level, experienceDrop, health, damage, name)
        {
        }
    }
}
