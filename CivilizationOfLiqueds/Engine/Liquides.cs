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
        public Liquides()
        {
            CurrentState = new StartOfSeason();
            Population = 2000;
        }
        public void Create(Liquides l)
        {
            int count = 0;
            int year = 150;
            Invasion invation = new Invasion();            
            for (int i = 0; i < year; i++)
            {
                if (invation.Catch(l) == false)                
                    StepOne();                
                else
                {
                    Crash.Destroy(l);
                    StepOne();
                    count++;
                }
            }
            Console.WriteLine($"\nWere {count} invansions for {year} years");
        }
        void StepOne()
        {
            CurrentState.ChangeState(this);
            CurrentState.Print(this);
        }
       
    }
}
