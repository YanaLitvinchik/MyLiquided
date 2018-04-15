using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivilizationOfLiqueds
{
    class Liquides
    {
        public long Population { get; set; }      
        public IState CurrentState { get; set; }
        public int Year { get; set; }
        public String Genius { get; set; }

        public Liquides()
        {
            CurrentState = new StartOfSeason();
            Population = 10000;
            Year = 100;
        }
        public void Create(Liquides l)
        {  
            Invasion invation = new Invasion();
            Crash crash = new Crash();
            for (int i = 0; i <= l.Year; i++)
            {
                if (invation.CatchPop(l) == false)                
                    StepOne();                
                else
                {
                    crash.Destroy(l);
                    invation.Alarm += crash.DestroyCompletely;
                    StepOne();                   
                }
            }            
        }
        void StepOne()
        {
            CurrentState.ChangeState(this);
            CurrentState.Print(this);
        }
       
    }
}
