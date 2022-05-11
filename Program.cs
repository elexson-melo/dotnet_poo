using System;
using dotnet_poo.Entities;
using dotnet_poo.src;
using dotnet_poo.src.Entities;

namespace dotnet_poo
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.Clear();
            Hero arus = new Knight("Arus", 42, "Knight", 469, 72);
            Wizard jennica = new Wizard("Jennica", 42, "White Wizard", 325, 89);
            Ninja wedge = new Ninja("Wedge", 42, "Ninja", 292, 89);
            BlackWizard topapa = new BlackWizard("Topapa", 42, "BlackWizard", 106, 611);

            Console.WriteLine(jennica.Attack(1));
            Console.WriteLine(jennica.Attack(7));
        }
    }
}
