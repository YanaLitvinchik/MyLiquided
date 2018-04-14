using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivilizationOfLiqueds
{
    public delegate void MessageExtraterrestrial();//extraterrestrial - пришелец
    internal class Invasion // вторжение
    {
        public event MessageExtraterrestrial Alarm;
        protected virtual void OnInvasion()
        {
            Alarm?.Invoke();
        }
        internal bool Catch(Liquides l)
        {
            if (l.Population > 1000000)
            {
                OnInvasion();
                return true;
            }
            else
                return false;
        }
    }


}
