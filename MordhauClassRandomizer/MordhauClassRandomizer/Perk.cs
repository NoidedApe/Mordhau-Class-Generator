using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MordhauClassRandomizer
{
    public class Perk
    {   // perk numbers have to be added together to make more than one perk active. Instead of 524288, 512 (mule and wrecker) it would be 524,800
        public int equipCost { get; set; }
       
        public int? ID { get; set; }
        public string name { get; set; }
        public Perk(int equipCost, string name, int iD)
        {
            this.equipCost = equipCost;
            this.name = name;
            ID = iD;
        }
        public Perk()
        {
            equipCost = 0;
            name = "None";
            ID = 0;
        }
        public Perk(string name)
        {
            this.name = name;
            this.equipCost = 0;
        }
    }   
}
