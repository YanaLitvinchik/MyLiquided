using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivilizationOfLiqueds
{
    class TurnToDark : IState // new liquides are born
    {
        public void ChangeState(Liquides l)
        {
            l.Population += (long)(l.Population * GenerateRandomMethod.GenerateRandom(50, 65));
            l.CurrentState = new ContinueDark();
        }

        public void Print(Liquides l)
        {
            Console.WriteLine($"\nTurn from sun.\nCurrent population : {l.Population}");
        }
    }
}
