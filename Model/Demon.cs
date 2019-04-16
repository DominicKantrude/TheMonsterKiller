using System;

namespace theMontsterKiller
{
    public class Demon : Monster, ICombustable, ISilverWeakness, IPurifiable
    {

        public Demon()
        {
            this.weaknesses.Add("Silver");
            this.weaknesses.Add("Fire");
            this.weaknesses.Add("Holy Water");
        }
        public void Burn()
        {
            Attack("Fire");
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