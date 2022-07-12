using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MordhauClassRandomizer
{
    public class Weapon
    {
       public int? ID { get; set; }
        public int equipCost { get; set; }
        public string name { get; set; }
        public Weapon(int equipCost, string name, int iD)
        {
            this.equipCost = equipCost;
            this.name = name;
            ID = iD;
        }
    }
}
