using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MordhauClassRandomizer
{
    internal class Info
    {
        #region lists
        List<armor> armors = new List<armor>()
        {   new armor("LightHelm", 3, "head"),
            new armor("MediumHelm", 6, "head"),
            new armor("HeavyHelm", 9, "head"),
            new armor("LightChest", 3, "chest"),
            new armor("MediumChest", 6, "chest"),
             new armor("HeavyChest", 9, "chest"),
             new armor("LightLegs", 1, "legs"),
             new armor("MediumLegs", 3, "legs"),
             new armor("HeavyLegs", 6, "legs"),
        };
        List<Perk> allperks = new List<Perk>()
        {
            new Perk(1, "mule"),
            new Perk(2, "scavenger"),
            new Perk(2, "supplied"),
            new Perk(2, "wrecker"),
            new Perk(3, "acrobat"),
            new Perk(3, "brawler"),
            new Perk(3, "butcher"),
            new Perk(3, "cat"),
            new Perk(3, "dwarf"),
            new Perk(3, "fireproof"),
            new Perk(3, "fury"),
            new Perk(3, "huntsman"),
            new Perk(3, "ranger"),
            new Perk(3, "smith"),
            new Perk(3, "stun"),
            new Perk(3, "tank"),
            new Perk(6, "bloodlust"),
            new Perk(6, "fleshwound"),
            new Perk(6, "rat"),
            new Perk(6, "rush"),
            new Perk(6, "secondwind"),
              new Perk(12, "dodge"),
                new Perk(24, "peasant"),

        };
        List<Weapon> weapons = new List<Weapon>()
        {
            new Weapon(1, "bandage"),
             new Weapon(1, "lute"),
              new Weapon(1, "shortsword"),
               new Weapon(1, "trainingsword"),
                new Weapon(1, "woodenmallet"),


                 new Weapon(2, "dagger"),
                 new Weapon(2, "paviseshield"),
                 new Weapon(2, "quarterstaff"),
                   new Weapon(2, "rock"),
                   new Weapon(2, "smokeBomb"),



                     new Weapon(3, "cleaver"),


                     new Weapon(4, "beartrap"),
                     new Weapon(4, "blacksmithhammer"),
                     new Weapon(4, "throwingaxe"),
                     new Weapon(4, "throwingknife"),
                     new Weapon(4, "warhammer"),


                     new Weapon(5, "axe"),
                     new Weapon(5, "targe"),


                     new Weapon(6, "armingSword"),
                     new Weapon(6, "fireBomb"),
                     new Weapon(6, "heaterShield"),
                     new Weapon(6, "medicBag"),
                     new Weapon(6, "shawm"),


                     new Weapon(8, "falchion"),


                     new Weapon(9, "buckler"),
                     new Weapon(9, "heavyHandAxe"),
                     new Weapon(9, "javelin"),
                     new Weapon(9, "kiteShield"),
                     new Weapon(9, "shortSpear"),


                     new Weapon(11, "mace"),


                     new Weapon(12, "bastardSword"),
                     new Weapon(12, "rapier"),
                     new Weapon(12, "roundShield"),


                     new Weapon(14, "billhook"),
                     new Weapon(14, "longsword"),


                     new Weapon(15, "battleaxe"),
                     new Weapon(15, "messer"),
                     new Weapon(15, "scimitar"),
                      new Weapon(15, "waraxe"),


                     new Weapon(18, "estoc"),
                     new Weapon(18, "falx"),
                     new Weapon(18, "poleaxe"),
                     new Weapon(18, "recurveBow"),


                     new Weapon(21, "crossbow"),
                     new Weapon(21, "eveningstar"),
                     new Weapon(21, "executionerssword"),
                     new Weapon(21, "greatsword"),
                     new Weapon(21, "maul"),
                     new Weapon(21, "partisan"),


                     new Weapon(24, "bardiche"),
                     new Weapon(24, "halberd"),
                     new Weapon(24, "polehammer"),
                     new Weapon(24, "spear"),
                     new Weapon(24, "toolBox"),
                     new Weapon(24, "zweihander"),


                    new Weapon(33, "longbow"),









        };
        #endregion
        #region equipCosts
        #region perks

        public int mule = 1;
        public int scavenger = 2;
        public int supplied = 2;
        public int wrecker = 2;
        public int acrobat = 3;
        public int brawler = 3;
        public int butcher = 3;
        public int cat = 3;
        public int dwarf = 3;
        public int fireproof = 3;
        public int fury = 3;
        public int huntsman = 3;
        public int ranger = 3;
        public int smith = 3;
        public int stun = 3;
        public int tank = 3;
        public int bloodlust = 6;
        public int fleshwound = 6;
        public int rat = 6;
        public int rush = 6;
        public int secondwind = 6;
        public int dodge = 12;
        public int peasant = 24;

        #endregion
        #region Armor
        public int lighthelm = 3;
        public int mediumhelm = 6;
        public int heavyhelm = 9;

        public int lightchest = 3;
        public int mediumchest = 6;
        public int heavychest = 9;


        public int lightlegs = 1;
        public int mediumlegs = 3;
        public int heavylegs = 6;





        #endregion
        #region weapons
        public int bandage = 1;
        public int lute = 1;
        public int shortsword = 1;
        public int trainingsword = 1;
        public int woodenmallet = 1;
        public int dagger = 2;
        public int paviseshield = 2;
        public int quarterstaff = 2;
        public int rock = 2;
        public int smokeBomb = 2;
        public int cleaver = 3;
        public int beartrap = 4;
        public int blacksmithhammer = 4;
        public int throwingaxe = 4;
        public int throwingknife = 4;
        public int warhammer = 4;
        public int axe = 5;
        public int targe = 5;
        public int armingSword = 6;
        public int fireBomb = 6;
        public int heaterShield = 6;
        public int medicBag = 6;
        public int shawm = 6;
        public int falchion = 8;
        public int buckler = 9;
        public int heavyHandAxe = 9;
        public int javelin = 9;
        public int kiteShield = 9;
        public int shortSpear = 9;
        public int mace = 11;
        public int bastardSword = 12;
        public int rapier = 12;
        public int roundShield = 12;
        public int billhook = 14;
        public int longsword = 14;
        public int battleaxe = 15;
        public int messer = 15;
        public int scimitar = 15;
        public int waraxe = 15;
        public int estoc = 18;
        public int falx = 18;
        public int poleaxe = 18;
        public int recurveBow = 18;
        public int crossbow = 21;
        public int eveningstar = 21;
        public int executionerssword = 21;
        public int greatsword = 21;
        public int maul = 21;
        public int partisan = 21;
        public int bardiche = 24;
        public int halberd = 24;
        public int polehammer = 24;
        public int spear = 24;
        public int toolBox = 24;
        public int zweihander = 24;
        public int longbow = 33;








        #endregion
        #endregion
    }
}
