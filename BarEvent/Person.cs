using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarEvent
{
    internal class Person
    {
        public string Name { get; set; }

        public void Eintreten(Bar bar)
        {
            // Für das Ereignis registrieren
            bar.EsWirdEineRundeAusgegeben += RundeEmpfangen;
            bar.EsWirdEineRundeAusgegeben2 += RundeEmpfangen2;
        }

        public void Verlassen(Bar bar)
        {
            // Das Ereignis deregistrieren
            bar.EsWirdEineRundeAusgegeben -= RundeEmpfangen;
            bar.EsWirdEineRundeAusgegeben2 -= RundeEmpfangen2;
        }

        private void RundeEmpfangen2(object? sender, DrinkEventArgs e)
        {
            string drinkType;
            if (e.Drink == DrinkType.Alcoholic)
                drinkType = "alkoholisches";
            else
                drinkType = "alkoholfreies";
            Console.WriteLine($"{this.Name} freut sich auf ein {drinkType} Getränk");
        }

        private void RundeEmpfangen(object? sender, EventArgs e)
        {
            Console.WriteLine($"{this.Name} freut sich auf ein Getränk");
        }
    }
}
