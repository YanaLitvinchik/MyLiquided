using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivilizationOfLiqueds
{
    class StartOfSeason : IState // the first day of the season : when all liquides are multiply their population
    {
        public void ChangeState(Liquides l)
        {
            l.CurrentState = new TurnToSun();
            Print(l);
        }
        public void Print(Liquides l)
        {
            Console.WriteLine($"The first day of the season is begun\nPopulation = {l.Population}");
        }
    }
}
