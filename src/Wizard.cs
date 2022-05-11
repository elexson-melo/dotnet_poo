using dotnet_poo.Entities;

namespace dotnet_poo.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType, int HealphPoint, int MealphPoint)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HealphPoint = HealphPoint;
            this.MealphPoint = MealphPoint;
        }
        public override string Attack()
        {
            return this.Name + "Lançou Magia";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + " Lançou Ataque super efetivo com bonus de " + Bonus;
            }
            else
            {
                return this.Name + " Lançou Ataque com força baixa com bonus de " + Bonus;
            }
        }
    }
}