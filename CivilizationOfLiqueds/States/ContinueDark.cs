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
            l.Population += (long)(l.Population * GenerateRandomMethod.GenerateRandom(10, 25));         
            l.CurrentState = new EndOfSeasonDark();
        }
        public void Print(Liquides l)
        {
            Console.WriteLine("Continue");
        }
    }
}
