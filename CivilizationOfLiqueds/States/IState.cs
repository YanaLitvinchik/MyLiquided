using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivilizationOfLiqueds
{
    interface IState
    {
        void ChangeState(Liquides l);
        void Print(Liquides l);
    }

    public class GenerateRandomMethod
    {
        public static double GenerateRandom(int start, int end)
        {
            return Program.random.Next(start, end) / 100.0;
        }
    }

}
