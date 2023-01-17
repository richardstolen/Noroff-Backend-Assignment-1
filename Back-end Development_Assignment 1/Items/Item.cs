using Back_end_Development_Assignment_1;

namespace Back_end_Development_Assignment_1
{
    public class Item
    {
        public string Name { get; set; }
        public int RequiredLevel { get; set; }
        public Slot Slot { get; set; }

        public Item(string name, int requiredLevel, Slot slot)
        {
            Name = name;
            RequiredLevel = requiredLevel;
            Slot = slot;
        }

        public override string ToString()
        {
            return $"{Name}\n      Required Level: {RequiredLevel}";
        }
    }
}