namespace dotnet_poo.Entities
{
    public abstract class Hero
    {
        public Hero(string Name, int Level, string HeroType, int HP, int MP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HealphPoint = HP;
            this.MealphPoint = MP;
        }
        public Hero() { }

        public string Name;
        public int Level;
        public string HeroType;
        public int HealphPoint;
        public int MealphPoint;

        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType + " " + this.HealphPoint + " " + this.MealphPoint;
        }

        public virtual string Attack()
        {
            return this.Name + " Atacou com sua espada";
        }
    }
}