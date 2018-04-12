using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivilizationOfLiqueds
{
    class ContinueDark : IState
    {
        public void ChangeState(Liquides l)
        {
            for (int i = 0; i < 100; i++)
            {
                l.Population += ((long)(l.Population * Metherology.GenerateRandom(1, 5)));
            }
            l.CurrentState = new EndOfSeasonDark();
        }
        public void Print(Liquides l)
        {
            Console.WriteLine("Continue");
        }
    }
}
