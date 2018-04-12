using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivilizationOfLiqueds
{
    class EndOfSeasonSun : IState
    {
        public void ChangeState(Liquides l)
        {
            l.CurrentState = new TurnToDark();
        }
        public void Print(Liquides l)
        {
            Console.WriteLine($"End of the sun season\nPopulation = {l.Population}");
        }
    }
}
