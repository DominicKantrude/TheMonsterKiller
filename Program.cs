using System;

namespace theMontsterKiller
{
    class Program
    {
        static void Main(string[] args)
        {

            Hunter VonRimmersmark = new Hunter("Erich", "Von Rimmersmark");

            Mummy tuts = new Mummy();
            Wight bob = new Wight();
            Vampire billy = new Vampire();

            VonRimmersmark.Ignite(tuts);
            VonRimmersmark.SplashWater(bob);
            VonRimmersmark.WieldSilver(billy);
        }
    }
}
