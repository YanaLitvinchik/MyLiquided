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
    class TurnToDark : IState
    {
        public void ChangeState(Liquides l)
        {
            throw new NotImplementedException();
        }
    }
    //----------------------------
    class StartOfSeason : IState
    {
        public void ChangeState(Liquides l)
        {
            throw new NotImplementedException();
        }
    }
    class Continue : IState
    {
        public void ChangeState(Liquides l)
        {
            l.Population -= (long)(l.Population * 5);//5% die
//time
        }
    }
    class EndOfSeason : IState        
    {
        public void ChangeState(Liquides l)
        {
            //l.CurrentState = new State();
        }
    }
    
}
