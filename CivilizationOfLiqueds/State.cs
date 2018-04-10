using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//c.CurrentState = new ContinueWar();

namespace CivilizationOfLiquides
{
   
    class TurnToSun : IState//death 20 - 30% 
    {       
        public void ChangeState(Liquides l)
        {           
            l.Population -= (long)(l.Population * (Program.r.Next(20, 30)/100));
            l.CurrentState = new Continue();
        }
       
        void IState.Print(Liquides l)
        {
            Console.WriteLine( $"\nTurn to sun.\n Current population : {l.Population}");
        }
    }
    class TurnToDark : IState // new liquides are born
    {
        internal Random r = new Random();
        public void ChangeState(Liquides l)
        {
            l.Population += (long)(l.Population * (r.Next(20, 50) / 100));
            l.CurrentState = new Continue();
        }

        public void Print(Liquides l)
        {
            Console.WriteLine($"\nTurn from sun.\n Current population : {l.Population}");
        }
    }
    //----------------------------
    class StartOfSeason : IState // the first day of the season : when all liquides are multiply their population
    {
        internal Random r = new Random();
        public void ChangeState(Liquides l)
        {
            for (int i = 0; i < 128; i++)
               l.Population += (long)(l.Population * 0.07);                
            l.CurrentState = new Continue();
        }
        public void Print(Liquides l)
        {
            Console.WriteLine($"The first day of the season is begun");
        }
    }
    class Continue : IState
    {
        public void ChangeState(Liquides l)
        {
            for (int i = 0; i < 128; i++)
            {
                l.Population += (long)(l.Population * 0.005);
            }
            l.CurrentState = new EndOfSeason();
        }

        public void Print(Liquides l)
        {
            throw new NotImplementedException();
        }
    }
    class EndOfSeason : IState        
    {
        public void ChangeState(Liquides l)
        {
            l.CurrentState = new TurnToSun();
        }

        public void Print(Liquides l)
        {
            throw new NotImplementedException();
        }
    }
    
}
