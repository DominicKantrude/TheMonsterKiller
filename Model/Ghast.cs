using System;

namespace theMontsterKiller
{
    public class Ghast :Monster, IPurifiable, ICombustable
    {
         public Ghast()
        {
            this.weaknesses.Add("Holy Water");
            this.weaknesses.Add("Fire");
        }
        public void Burn()
        {
            Attack("Fire");
        }

        public void Purify()
        {
            Attack("Holy Water");
        }

    }
}