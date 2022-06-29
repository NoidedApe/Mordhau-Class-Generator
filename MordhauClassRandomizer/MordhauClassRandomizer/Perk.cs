using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MordhauClassRandomizer
{
    public class Perk
    {
        public int equipCost { get; set; }
        public string name { get; set; }
        public Perk(int equipCost, string name)
        {
            this.equipCost = equipCost;
            this.name = name;
        }
    }
}
