using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_poo.Entities;

namespace dotnet_poo.src
{
    public class BlackWizard : Hero
    {
        public BlackWizard(string Name, int Level, string HeroType, int HealphPoint, int MealphPoint)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HealphPoint = HealphPoint;
            this.MealphPoint = MealphPoint;
        }

        public override string Attack()
        {
            return this.Name + " Lançou Feitiço";
        }
    }
}
