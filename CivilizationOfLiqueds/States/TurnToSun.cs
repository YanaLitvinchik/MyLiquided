using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivilizationOfLiqueds
{
    class TurnToSun : IState//death 20 - 30% 
    {
        public void ChangeState(Liquides l)
        {
            l.Population -= (long)(l.Population * Metherology.GenerateRandom(20,30));
            l.CurrentState = new ContinueSun();
        }
        public void Print(Liquides l)
        {
            Console.WriteLine($"\nTurn to sun.\nCurrent population : {l.Population}");
        }

    }
}
