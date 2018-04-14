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
            if (l.Population < 5)
                l.Population += 10;
            l.Population -= (long)(l.Population * GenerateRandomMethod.GenerateRandom(30,35));
            l.CurrentState = new ContinueSun();
        }
        public void Print(Liquides l)
        {
            Console.WriteLine($"\nTurn to sun.\nCurrent population : {l.Population}");
        }

    }
}
