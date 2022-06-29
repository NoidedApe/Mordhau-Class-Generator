using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MordhauClassRandomizer
{
    public class ConsumablesAndThrowables
    {
        public int equipCost { get; set; }
        public string name { get; set; }
        public ConsumablesAndThrowables(int equipCost, string name)
        {
            this.equipCost = equipCost;
            this.name = name;
        }
    }
}
