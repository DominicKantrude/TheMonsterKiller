using System;
using System.Collections.Generic;

namespace theMontsterKiller
{
    public class Monster
    {
       public List<string> weaknesses {get;set;} = new List<string>();



        public void Attack(string attack)
        {
            if (weaknesses.Contains(attack))
            {
                Console.WriteLine($"You just killed the {this.GetType().Name} with {attack}");
            }
        }
    }
}