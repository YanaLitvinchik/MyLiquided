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
        public long TimeChanging { get; set; }
        public IState CurrentState { get; set; }
    }
}
