using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivilizationOfLiquides
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
            StepOne();
        }
        void StepOne()
        {
            CurrentState.ChangeState(this);
            CurrentState.Print(this);
        }
    }
}
