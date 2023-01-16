using Back_end_Development_Assignment_1.Items;

namespace Back_end_Development_Assignment_1
{
    public class HeroAttribute
    {
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }

        public HeroAttribute()
        {
            Strength = 1;
            Dexterity = 1;
            Intelligence = 1;
        }

        public HeroAttribute(int strength, int dexterity, int intelligence)
        {
            Strength = strength;
            Dexterity = dexterity;
            Intelligence = intelligence;
        }

        public void levelUp(int strength, int dexterity, int intelligence)
        {
            Strength += strength;
            Dexterity += dexterity;
            Intelligence += intelligence;
        }

        public HeroAttribute addArmorAttribute(ArmorAttribute attribute)
        {
            return new HeroAttribute(Strength + attribute.Strength, Dexterity + attribute.Dexterity
                , Intelligence + attribute.Intelligence);
        }

        public override string ToString()
        {
            return $"Strength: {Strength}\nDexterity: {Dexterity}\nIntelligence: {Intelligence}";
        }
    }
}