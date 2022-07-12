using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MordhauClassRandomizer
{
    public class Shields
    {   public int? ID { get; set; }
        public int equipCost { get; set; }
        public string name { get; set; }
        public Shields(int equipCost, string name, int id)
        {
            this.equipCost = equipCost;
            this.name = name;
            this.ID = id;
        }
        public Shields (int equipCost, string name)
        {
            this.equipCost = equipCost;
            this.name = name;
        }
    }
}
