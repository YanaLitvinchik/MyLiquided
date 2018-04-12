using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivilizationOfLiqueds
{
    class ContinueSun : IState
    {
        public void ChangeState(Liquides l)
        {
            l.Population -= ((long)(l.Population * Metherology.GenerateRandom(1, 7)));
            l.CurrentState = new EndOfSeasonSun();
        }

        public void Print(Liquides l)
        {
            Console.WriteLine("Continue");
        }
    }
}
