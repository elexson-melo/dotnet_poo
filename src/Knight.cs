using dotnet_poo.Entities;

namespace dotnet_poo.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType, int HealphPoint, int MealphPoint)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HealphPoint = HealphPoint;
            this.MealphPoint = MealphPoint;
        }
        public override string Attack()
        {
            return this.Name + " Atacou com sua Lança";
        }
    }
}