using System;

namespace theMontsterKiller
{
    public class Vampire : Monster, ICombustable, ISilverWeakness
    {
        public Vampire()
        {
            this.weaknesses.Add("Silver");
            this.weaknesses.Add("Fire");
        }
        public void Burn()
        {
            Attack("Fire");
        }

        public void silvered()
        {
            Attack("Silver");
        }
    }
}