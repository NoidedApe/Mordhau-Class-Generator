using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MordhauClassRandomizer
{
    public class armor
    {
        public string name { get; set; }
        public int equipCost { get; set; }

        public string slot { get; set; }

        public armor (string name, int equipCost, string slot)
        {
            this.name = name;
            this.equipCost = equipCost;
            this.slot = slot;
        }
    }
}
