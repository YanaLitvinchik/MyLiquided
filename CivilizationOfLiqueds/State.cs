using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//c.CurrentState = new ContinueWar();

namespace CivilizationOfLiquides
{
   
    class TurnToSun : IState//умирают  с вероятностью от 20 - 30 %
    {
        static protected Random r = new Random();
        public void ChangeState(Liquides l)
        {           
            l.Population -= (long)(l.Population * (r.Next(20, 30)/100));
            l.CurrentState = new Continue();
        }
    }
    class TurnToDark : IState
    {
        static protected Random r = new Random();
        public void ChangeState(Liquides l)
        {
            l.Population += (long)(l.Population * (r.Next(20, 50) / 100));
            l.CurrentState = new Continue();
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
