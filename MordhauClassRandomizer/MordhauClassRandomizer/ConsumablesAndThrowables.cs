using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MordhauClassRandomizer
{
    public class ConsumablesAndThrowables
    {
        public int? ID { get; set; }

        public int equipCost { get; set; }
        public string? name { get; set; }
        public ConsumablesAndThrowables(int equipCost, string name, int iD)
        {
            this.equipCost = equipCost;
            this.name = name;
            ID = iD;
        }
        public ConsumablesAndThrowables(int equipCost, string name)
        {
            this.equipCost = equipCost;
            this.name = name;

        }
    }
}
