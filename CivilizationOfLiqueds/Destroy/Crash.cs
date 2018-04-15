using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivilizationOfLiqueds
{
    internal class Crash //if population more than 1 000 000 
    {
        internal void Destroy(Liquides l)
        {
            l.Population -= (long)(l.Population * GenerateRandomMethod.GenerateRandom(80,90));
        }
        internal void DestroyCompletely()
        {
            string str = "extraterrestrialses attacked";
            Console.WriteLine($"------------------------------{str.ToUpper()}");
        }
    }
}
