using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivilizationOfLiqueds
{
    public class Crash                                                       //if population more than 1 000 000 
    {
        internal static void Destroy(Liquides l)
        {
            Console.WriteLine("-------------------------------------------------------------NAPALI INOPLANETNIE PEOPLE");
            l.Population -= (long)(l.Population * GenerateRandomMethod.GenerateRandom(80,90));
        }        
    }
}
