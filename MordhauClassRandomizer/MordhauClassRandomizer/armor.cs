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

        public int? ID { get; set; }

        public armor (string name, int equipCost, int ID)
        {
            this.name = name;
            this.equipCost = equipCost;
            this.ID = ID;
        }
        public armor (string name, int equipCost)
        {
            this.name = name;
            this.equipCost = equipCost;
        }
        public armor ()
        {

        }
    }
}
