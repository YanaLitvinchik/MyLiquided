using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivilizationOfLiquides
{
    interface IState
    {
        void ChangeState(Liquides l);
        void Print(Liquides l);
    }
}
