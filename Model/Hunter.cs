using System;
using System.Collections.Generic;

namespace theMontsterKiller
{
    public class Hunter
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<string> Weapons { get; } = new List<string>() {
        "Silver", "Fire", "Holy Water"
    };

        public Hunter(string first, string last)
        {
            FirstName = first;
            LastName = last;
        }

        public void AttackMonster(Monster monster)
        {
            monster.Attack("Fire");
        }

        public void SplashWater(Wight wight)
        {
            wight.silvered();  // Kills with holy water
        }

        public void Ignite(Mummy mummy)
        {
            mummy.Burn();  // Kills with fire
        }

        public void WieldSilver(Vampire vamp)
        {
            vamp.silvered();   // Stabs with silver knife
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} kills monsters with the following weapons: {String.Join(", ", Weapons)}";
        }
    }
}