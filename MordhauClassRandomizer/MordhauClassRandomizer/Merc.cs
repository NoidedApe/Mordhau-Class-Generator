using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MordhauClassRandomizer
{
    public class Merc
    {
        public int equipPoints = 48;

        public armor head;
        public armor chest;
        public armor legs;
        public Weapon Weapon;
        public Perk Perk1, Perk2, Perk3;
        public ConsumablesAndThrowables Consumable, throwable;
        public Shields Shield;

      
        public Merc (armor head, armor chest, armor legs, Weapon weapon, Perk perk1, Perk perk2, Perk perk3)
        {
            this.head = head;
            this.chest = chest;
            this.legs = legs;
            this.Weapon = weapon;
            this.Perk1 = perk1;
            this.Perk2 = perk2;
            this.Perk3 = perk3;


        }

        public Merc(armor head, armor chest, armor legs, Weapon weapon)
        {
            this.head = head;
            this.chest = chest;
            this.legs = legs;
            this.Weapon = weapon;


        }

        public Merc()
        {
            this.Consumable = new ConsumablesAndThrowables(0, "nothing");
            this.Shield = new Shields(0, "nothing");
            this.throwable = new ConsumablesAndThrowables(0, "nothing");
        }
















    }
}
