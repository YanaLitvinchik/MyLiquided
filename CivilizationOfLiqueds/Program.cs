using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivilizationOfLiqueds
{
    class Program
    {
        static public Random random = new Random();
        static void Main(string[] args)
        {
            Liquides l = new Liquides();
            l.Create(l);     
            l.Create(l);
            l.Create(l);
            l.Create(l);
            l.Create(l);
            l.Create(l);
        }
    }
}
