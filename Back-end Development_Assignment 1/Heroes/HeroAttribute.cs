using Back_end_Development_Assignment_1.Items;

namespace Back_end_Development_Assignment_1
{
    public class HeroAttribute
    {
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }

        public HeroAttribute(int strength, int dexterity, int intelligence)
        {
            Strength = strength;
            Dexterity = dexterity;
            Intelligence = intelligence;
        }

        /// <summary>
        /// Level up method that increases the Hero attributes and saves them to the hero 
        /// </summary>
        /// <param name="strength"></param>
        /// <param name="dexterity"></param>
        /// <param name="intelligence"></param>
        public void levelUp(int strength, int dexterity, int intelligence)
        {
            Strength += strength;
            Dexterity += dexterity;
            Intelligence += intelligence;
        }

        /// <summary>
        /// A method used in the totalAttributes method in the Hero class
        /// Makes it easier to calculate total attributes from each armor
        /// </summary>
        /// <param name="attribute"></param>
        public void addArmorAttribute(ArmorAttribute attribute)
        {
            this.Strength += attribute.Strength;
            this.Dexterity += attribute.Dexterity;
            this.Intelligence += attribute.Intelligence;
        }

        public override string ToString()
        {
            return $"Strength: {Strength}\nDexterity: {Dexterity}\nIntelligence: {Intelligence}";
        }
    }
}