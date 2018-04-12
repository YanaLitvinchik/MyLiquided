using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivilizationOfLiqueds
{
    class EndOfSeasonDark : IState
    {
        public void ChangeState(Liquides l)
        {
            l.CurrentState = new TurnToSun();
        }

        public void Print(Liquides l)
        {
            Console.WriteLine($"End of the dark season\nPopulation = {l.Population}");
        }
    }
}
