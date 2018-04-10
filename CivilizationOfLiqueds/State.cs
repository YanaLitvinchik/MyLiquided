using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CivilizationOfLiquides
{   
    class TurnToSun : IState//death 20 - 30% 
    {       
        public void ChangeState(Liquides l)
        {
            l.Population -= (long)(l.Population * (Program.r.Next(20, 30) / 100));
            l.CurrentState = new Continue();
        }
       
        public void Print(Liquides l)
        {
            Console.WriteLine( $"\nTurn to sun.\nCurrent population : {l.Population}");
        }
        
    }
    class TurnToDark : IState // new liquides are born
    {
        
        public void ChangeState(Liquides l)
        {
            l.Population += (long)(l.Population * (Program.r.Next(20, 50) / 100));
            l.CurrentState = new Continue();
        }

        public void Print(Liquides l)
        {
            Console.WriteLine($"\nTurn from sun.\nCurrent population : {l.Population}");
        }      

    }
    //----------------------------
    class StartOfSeason : IState // the first day of the season : when all liquides are multiply their population
    {       
        public void ChangeState(Liquides l)
        {
            for (int i = 0; i < 14; i++)
            {
                l.CurrentState = new TurnToDark();
            }
                Print(l);
    
        }
        public void Print(Liquides l)
        {
            Console.WriteLine($"The first day of the season is begun\nPopulation = {l.Population}");
        }
    }
    class Continue : IState
    {
        public void ChangeState(Liquides l)
        {
            for (int i = 0; i < 100; i++)
            {
                l.Population += (long)(l.Population * 0.005);
            }
            l.CurrentState = new EndOfSeason();
        }

        public void Print(Liquides l)
        {
            Console.WriteLine("Continue");
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
            Console.WriteLine($"End of the season\nPopulation = {l.Population}");
        }
    }
}
