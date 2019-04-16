using System;

namespace theMontsterKiller
{
    public class Ghoul :Monster, IPurifiable, ISilverWeakness
    {
         public Ghoul()
        {
            this.weaknesses.Add("Holy Water");
            this.weaknesses.Add("Silver");
        }
        public void Purify()
        {
            Attack("Holy Water");
        }

        public void silvered()
        {
            Attack("Silver");
        }
    }
}