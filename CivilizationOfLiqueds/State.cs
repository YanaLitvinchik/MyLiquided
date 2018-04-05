using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//c.CurrentState = new ContinueWar();
namespace CivilizationOfLiquides
{    
    class TurnToSun : IState
    {
        public void ChangeState(Liquides l)
        {
            Random r = new Random();
            l.Population -= (long)(l.Population * r.Next(20, 30));
            //l.CurrentState = new State();
        }
    }
    class Continue : IState
    {
        public void ChangeState(Liquides l)
        {
            l.Population -= (long)(l.Population * 5);//5% die

        }
    }
}
