using System;

namespace theMontsterKiller
{
    public class Mummy : Monster, ICombustable
    {
        public Mummy()
        {
            weaknesses.Add("Fire");
        }
        public void Burn()
        {
            Attack("Fire");
        }
    }
}