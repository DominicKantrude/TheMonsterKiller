using System;

namespace theMontsterKiller
{
    public class Wight : Monster, ISilverWeakness
    {
        public Wight()
        {
            this.weaknesses.Add("Silver");

        }
        public void silvered()
        {
            Attack("Silver");
        }
    }
}