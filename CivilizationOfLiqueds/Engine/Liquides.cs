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
            Population = 1000;
        }
        public void Create()
        {
            for (int i = 0; i < 10; i++)
            {
                StepOne();
                //Population > 1000000;  
            }
        }
        void StepOne()
        {
            CurrentState.ChangeState(this);
            CurrentState.Print(this);
        }
       
    }
}
