namespace Back_end_Development_Assignment_1
{
    public class Weapon : Item
    {
        public WeaponType WeaponType { get; set; }
        public int WeaponDamage { get; set; }

        public Weapon(string name, int requiredLevel, Slot slot, WeaponType weaponType, int weaponDamage) : base(name, requiredLevel, slot)
        {
            WeaponType = weaponType;
            WeaponDamage = weaponDamage;
        }

        public override string ToString()
        {
            return base.ToString() + $"\n      Weapon type: {WeaponType}\n      Weapon damage: {WeaponDamage}";
        }
    }
}