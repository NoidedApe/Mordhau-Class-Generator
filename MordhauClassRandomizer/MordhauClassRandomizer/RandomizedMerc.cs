using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;
namespace MordhauClassRandomizer
{
    public class RandomizedMerc
    {
       

        #region lists
        List<armor> armors = new List<armor>()
        {   new armor("LightHelm", 3, 1),
            new armor("MediumHelm", 6, 5),
            new armor("HeavyHelm", 9, 10),
            new armor("LightChest", 3, 7),
            new armor("MediumChest", 6, 3),
             new armor("HeavyChest", 9, 4),
             new armor("LightLegs", 1, 11),
             new armor("MediumLegs", 3, 9),
             new armor("HeavyLegs", 6, 4),
             new armor("nothing", 0)
        };
        List<Perk> allperks = new List<Perk>()
        {
            new Perk(1, "mule",524288),
            new Perk(2, "scavenger",65536),
            new Perk(2, "supplied",4194304),
            new Perk(2, "wrecker",512),
            new Perk(3, "acrobat",2),
            new Perk(3, "brawler",1),
            new Perk(3, "butcher",1048576),
            new Perk(3, "cat",256),
            new Perk(3, "dwarf",2048),
            new Perk(3, "fireproof",16),
            new Perk(3, "fury",4),
            new Perk(3, "huntsman",32),
            new Perk(3, "ranger",262144),
            new Perk(3, "smith",1024),
            new Perk(3, "stun",2097152),
            new Perk(3, "tank",64),
            new Perk(6, "bloodlust",8192),
            new Perk(6, "fleshwound",32768),
            new Perk(6, "rat",128),
            new Perk(6, "rush",16384),
            new Perk(6, "secondwind",4096),
              new Perk(12, "dodge",131072),
                new Perk(24, "peasant", 8),

        };
        List<Weapon> weapons = new List<Weapon>()
        {
           
             new Weapon(1, "lute",53),
              new Weapon(1, "shortsword",12),
               new Weapon(1, "trainingsword",36),
                new Weapon(1, "woodenmallet",30),
                 new Weapon(2, "dagger",19),
                 new TwoHanded(2, "quarterstaff",16),
                     new Weapon(3, "cleaver",56),
                     new Weapon(4, "blacksmithhammer",29),
                     new Weapon(4, "warhammer",8),
                     new Weapon(5, "axe",13),
                     new Weapon(6, "armingSword",4), 
                     new Weapon(6, "shawm",69),
                     new Weapon(8, "falchion",22),                     
                     new Weapon(9, "heavyHandAxe",63),
                                   
                     new Weapon(9, "shortSpear",25),
                     new Weapon(11, "mace",17),
                     new Weapon(12, "bastardSword",2),
                     new Weapon(12, "rapier",23),               
                     new TwoHanded(14, "billhook",20),
                    new TwoHanded(14, "longsword",1),
                     new TwoHanded(15, "battleaxe",7),
                     new Weapon(15, "messer",24),
                     new Weapon(15, "scimitar",70),
                      new TwoHanded(15, "waraxe",35),
                     new Weapon(18, "estoc",26),
                     new TwoHanded(18, "falx",67),
                     new TwoHanded(18, "poleaxe",6),
                     new TwoHanded(18, "recurveBow",52),
                     new TwoHanded(21, "crossbow",50),
                     new TwoHanded(21, "eveningstar",21),
                     new TwoHanded(21, "executionerssword",37),
                     new TwoHanded(21, "greatsword",10),
                     new TwoHanded(21, "maul",31),
                     new Weapon(21, "partisan",58),
                     new TwoHanded(24, "bardiche",18),
                     new TwoHanded(24, "halberd",5),
                     new TwoHanded(24, "polehammer",65),
                     new Weapon(24, "spear",11),                     
                     new TwoHanded(24, "zweihander",3),
                    new TwoHanded(33, "longbow",51),
        };
        List<Shields> shields = new List<Shields>()
        {
             new Shields(2, "paviseshield",55),
            new Shields(5, "targe",15),
              new Shields(6, "heaterShield",14),
               new Shields(9, "kiteShield",9),
                new Shields(12, "roundShield",66),
                new Shields(9, "buckler",61),
                 new Shields(0, "nothing")






        };
        List<ConsumablesAndThrowables> ConsumablesAndThrowables = new List<ConsumablesAndThrowables>()
        {     new ConsumablesAndThrowables(2, "smokeBomb",28),
             new ConsumablesAndThrowables(1, "bandage",58),
            new ConsumablesAndThrowables(24, "toolBox",59),
             new ConsumablesAndThrowables(6, "fireBomb",27),
              new ConsumablesAndThrowables(6, "medicBag",57),
               new ConsumablesAndThrowables(4, "beartrap",54),
                new ConsumablesAndThrowables(2, "rock",34),
                 new ConsumablesAndThrowables(4, "throwingknife",33),
                    new ConsumablesAndThrowables(4, "throwingaxe",32),
                    new ConsumablesAndThrowables(0, "nothing"),
               new ConsumablesAndThrowables(9, "javelin",64)
        };

        #endregion
       

        public armor GenerateHead()
        {   Random random = new Random();
            
            armor currenthead = armors[random.Next(0, 3)];
            return currenthead;

        }
        public armor GenerateChest()
        {
            Random random = new Random();

            armor currentchest = armors[random.Next(3, 6)];
          return currentchest;

        }
        public armor GenerateLegs()
        {
            Random random = new Random();
            armor currentlegs = armors[random.Next(7, armors.Count)];
            return currentlegs;

        }
        public Weapon GenerateWeapon()
        {
            Random random = new Random();
            Weapon currentWeapon = weapons[random.Next(0, weapons.Count)];
            return currentWeapon;



        }
        public Perk GeneratePerk()
        {

            Random random = new Random();
            Perk currentPerk = allperks[random.Next(0, allperks.Count)];
            return currentPerk;



        }
        public ConsumablesAndThrowables GenerateCAB()
        {

            Random random = new Random();
            ConsumablesAndThrowables currentPerk = ConsumablesAndThrowables[random.Next(0, ConsumablesAndThrowables.Count)];
            return currentPerk;



        }
        public Shields GenerateShield()
        {

            Random random = new Random();
            Shields currentPerk = shields[random.Next(0, shields.Count)];
            return currentPerk;



        }

        public bool HaveArmorOrNot()
        {
            Random random = new Random();
            int yesno = random.Next(0, 10);
            if (yesno > 7)
            {
                return false;

            }else
            {
                return true;
            }


            
        }
        public Merc GetMerc()
        {
            int i = 0;
            List<Perk> currentperks = new List<Perk>();
            List<int> equipment = new List<int>();
            Merc rand = new Merc();
            bool perk1peasant = false, perk2peasant = false, perk3peasant = false;
            do
            {
                if (rand.equipPointsRemaining > 0 && rand.Weapon == null && !perk1peasant && !perk2peasant && !perk3peasant) { rand.Weapon = GenerateWeapon(); equipment.Add(rand.Weapon.equipCost); }                                   
                if (equipment.Count > 0)
                {
                    for (int i1 = 0; i1 < equipment.Count; i1++)
                    {
                        int j = equipment[i1];
                        rand.equipPointsRemaining -= j;
                        equipment.Remove(j);
                    }
                }
                if (rand.equipPointsRemaining < 10)
                    break;

                armor head = new armor();
                if (head.equipCost < rand.equipPointsRemaining && rand.head == null && HaveArmorOrNot() == true && !perk1peasant && !perk2peasant && !perk3peasant)
                { 
                       head = GenerateHead();
                    if (rand.head == null && head.equipCost < rand.equipPointsRemaining) {rand.head = head; equipment.Add(rand.head.equipCost); }
                }
                if (equipment.Count > 0)
                {
                    for (int i1 = 0; i1 < equipment.Count; i1++)
                    {
                        int j = equipment[i1];
                        rand.equipPointsRemaining -= j;
                        equipment.Remove(j);
                    }

                }
                if (rand.equipPointsRemaining < 10)
                    break;

                armor chest = new armor();
                if (chest.equipCost < rand.equipPointsRemaining && rand.chest == null && HaveArmorOrNot() == true && !perk1peasant && !perk2peasant && !perk3peasant)
                { chest = GenerateChest();
                  if (rand.chest == null && chest.equipCost < rand.equipPointsRemaining) { rand.chest = chest;equipment.Add(rand.chest.equipCost); }
                }
                if (equipment.Count > 0)
                {
                    for (int i1 = 0; i1 < equipment.Count; i1++)
                    {
                        int j = equipment[i1];
                        rand.equipPointsRemaining -= j;
                        equipment.Remove(j);
                    }
                }
                if (rand.equipPointsRemaining < 10)
                    break;
                ConsumablesAndThrowables consumable1 = GenerateCAB();
                if (rand.Consumable.ID == null && consumable1.equipCost < rand.equipPointsRemaining)
                    rand.Consumable = consumable1; equipment.Add(rand.Consumable.equipCost);
                if (equipment.Count > 0)
                {
                    for (int i1 = 0; i1 < equipment.Count; i1++)
                    {
                        int j = equipment[i1];
                        rand.equipPointsRemaining -= j;
                        equipment.Remove(j);
                    }
                }
                if (rand.equipPointsRemaining < 10)
                    break;
                armor legs = new armor();
                if (legs.equipCost < rand.equipPointsRemaining && rand.legs == null && HaveArmorOrNot() == true && !perk1peasant && !perk2peasant && !perk3peasant)
                { legs = GenerateLegs();
                  if (rand.legs == null && legs.equipCost < rand.equipPointsRemaining) { rand.legs = legs; equipment.Add(rand.legs.equipCost); }                                      
                }
                if (equipment.Count > 0)
                {
                    for (int i1 = 0; i1 < equipment.Count; i1++)
                    {
                        int j = equipment[i1];
                        rand.equipPointsRemaining -= j;
                        equipment.Remove(j);
                    }
                }
                if (rand.equipPointsRemaining < 10)
                    break;
                Perk perk1 = GeneratePerk();
               perk1peasant = perk1.equipCost == 24;
                if (perk1.equipCost < rand.equipPointsRemaining && rand.Perk1 == null)
                { if (!perk1peasant)
                    {   rand.Perk1 = perk1;
                        equipment.Add(rand.Perk1.equipCost);
                    }
                    else if (perk1peasant && perk1.equipCost < rand.equipPointsRemaining && rand.Perk1 == null)
                    {
                        rand.Perk1 = perk1;
                        equipment.Add(rand.Perk1.equipCost);
                        rand.head = null; rand.chest = null; rand.legs = null;
                    }
                    else { Perk perk = new Perk(""); rand.Perk1 = perk; }
                }

                if (equipment.Count > 0)
                {
                    for (int i1 = 0; i1 < equipment.Count; i1++)
                    {
                        int j = equipment[i1];
                        rand.equipPointsRemaining -= j;
                        equipment.Remove(j);
                    }
                }
                if (rand.equipPointsRemaining < 10)
                    break;

                Shields shield = GenerateShield();
                if (Compare(rand.Weapon, weapons[5]) == false && shield.equipCost < rand.equipPointsRemaining && !perk1peasant && !perk2peasant && !perk3peasant)
                    rand.Shield = GenerateShield(); equipment.Add(rand.Shield.equipCost);
                Perk perk2 = GeneratePerk();
               perk2peasant = perk2.equipCost == 24;
                if (perk2.equipCost < rand.equipPointsRemaining && rand.Perk2 == null && rand.Perk1 != null && perk2.name != rand.Perk1.name)
                {       rand.Perk2 = perk2;
                        equipment.Add(rand.Perk2.equipCost);         
                }
                else { Perk perk = new Perk(""); rand.Perk2 = perk; }
                if (equipment.Count > 0)
                {
                    for (int i1 = 0; i1 < equipment.Count; i1++)
                    {
                        int j = equipment[i1];
                        rand.equipPointsRemaining -= j;
                        equipment.Remove(j);
                    }
                }
                if (rand.equipPointsRemaining < 10)
                    break;
                
                Perk perk3 = GeneratePerk();
              perk3peasant = perk3.equipCost == 24;
                if (perk3.equipCost < rand.equipPointsRemaining && rand.Perk3 == null && rand.Perk1 != null && rand.Perk2 != null && perk3.name != rand.Perk1.name && perk3.name != rand.Perk2.name)
                { rand.Perk3 = perk3; equipment.Add(rand.Perk3.equipCost);}
                else { Perk perk = new Perk(""); rand.Perk3 = perk; }
                if (equipment.Count > 0)
                {
                    for (int i1 = 0; i1 < equipment.Count; i1++)
                    {
                        int j = equipment[i1];
                        rand.equipPointsRemaining -= j;
                        equipment.Remove(j);
                    }
                }
                if (rand.equipPointsRemaining < 5)
                    break;

                ConsumablesAndThrowables consumable2 = GenerateCAB();
                if (rand.throwable.ID == null && rand.Weapon != null && rand.Perk1 != null && rand.Consumable.ID != consumable2.ID  && consumable2.equipCost < rand.equipPointsRemaining)
                    rand.throwable = consumable2; equipment.Add(rand.throwable.equipCost);
                if (rand.equipPointsRemaining < 10)
                    break;
                if (perk1peasant || perk2peasant || perk3peasant)
                    rand.head = null; rand.legs = null; rand.chest = null;
                if (equipment.Count > 0)
                {
                    for (int i1 = 0; i1 < equipment.Count; i1++)
                    {
                        int j = equipment[i1];
                        rand.equipPointsRemaining -= j;
                        equipment.Remove(j);
                    }
                }
                if (perk1peasant || perk2peasant || perk3peasant)
                {
                    if (rand.legs != null)
                        rand.equipPointsRemaining += rand.legs.equipCost;
                    if (rand.chest != null)
                        rand.equipPointsRemaining += rand.chest.equipCost;
                    if (rand.head != null)
                        rand.equipPointsRemaining += rand.head.equipCost;
                    rand.head = armors[9]; rand.chest = armors[9]; rand.legs    = armors[9];
                }
              
               
                if (rand.equipPointsRemaining < 10)
                    break;
               
                i++;
            } while (i < 15 || rand.equipPointsRemaining > 10);
            if (rand.equipPointsRemaining < 0)
                GetMerc();

            return rand;











            #region oldScript
            /*
          
            Merc randomMerc = new Merc();
            int equipPointsRemaining = 48;

            if (equipPointsRemaining > 0)
            {
                Perk tempperk1 = GeneratePerk();
                if (tempperk1.equipCost + equipPointsRemaining! > randomMerc.equipPoints)
                {
                    randomMerc.Perk1 = tempperk1;
                    equipPointsRemaining -= tempperk1.equipCost;

                }

            }
            if (equipPointsRemaining > 0 && randomMerc.Perk1.equipCost != 24)
                {
                bool yesno = HaveArmorOrNot();
                 if (yesno)
                 {
                    randomMerc.head = GenerateHead();
                    equipPointsRemaining -= randomMerc.head.equipCost;
                  }
                else
                {
                    randomMerc.head = armors[9];

                }

            }
            else
            {
                randomMerc.head = armors[9];

            }
            if (equipPointsRemaining > 0 && randomMerc.Perk1.equipCost != 24)
                 {
                        bool yesno = HaveArmorOrNot();
                        if (yesno)
                {
                    randomMerc.legs = GenerateLegs();
                    equipPointsRemaining -= randomMerc.legs.equipCost;

                }
                else
                {
                    randomMerc.legs = armors[9];

                }


            }
            else
            {
                randomMerc.legs = armors[9];

            }
           
            if (equipPointsRemaining > 0)
            {
                bool yesno = HaveArmorOrNot();
                if (yesno)
                {
                    randomMerc.Consumable = GenerateCAB();
                    equipPointsRemaining -= randomMerc.Consumable.equipCost;

                }
                else
                {
                    randomMerc.Consumable = ConsumablesAndThrowables[ConsumablesAndThrowables.Count - 1];

                }


            }
            else
            {
                randomMerc.Consumable = ConsumablesAndThrowables[ConsumablesAndThrowables.Count - 1];

            }

            if (equipPointsRemaining > 0)
            {
                Perk tempperk2 = GeneratePerk();
                if (tempperk2.equipCost + equipPointsRemaining! > randomMerc.equipPoints)
                {

                    randomMerc.Perk2 = tempperk2;
                    equipPointsRemaining -= tempperk2.equipCost;
                }
            }
            if (equipPointsRemaining > 0 && randomMerc.Perk1.equipCost != 24)
            {
                bool yesno = HaveArmorOrNot();
                if (yesno)
                {
                    randomMerc.chest = GenerateChest();
                    equipPointsRemaining -= randomMerc.chest.equipCost;
                }
                else
                {
                    randomMerc.chest = armors[9];

                }


            }
            else
            {
                randomMerc.chest = armors[9];

            }
            if (equipPointsRemaining > 0)
                {
                    randomMerc.Weapon = GenerateWeapon();
                    equipPointsRemaining -= randomMerc.Weapon.equipCost;

                }
            if (equipPointsRemaining > 0)
            {

                if (randomMerc.Weapon != null && Compare(randomMerc.Weapon, weapons[5]) == false)
                {
                    randomMerc.Shield = GenerateShield();
                    equipPointsRemaining -= randomMerc.Shield.equipCost;

                }
                else
                {
                    randomMerc.Shield = shields[shields.Count - 1];

                }


            }
            else
            {
                randomMerc.Shield = shields[shields.Count - 1];

            }




            if (equipPointsRemaining > 0) 
            {
                Perk tempperk3 = GeneratePerk();
                if (tempperk3.equipCost + equipPointsRemaining !> randomMerc.equipPoints)
                {
                    randomMerc.Perk3 = tempperk3;
                    equipPointsRemaining -= tempperk3.equipCost;

                }

            }
           



            if (equipPointsRemaining >= 0 && equipPointsRemaining < 10 && randomMerc.Weapon != null && randomMerc.chest != null && randomMerc.head != null && randomMerc.legs != null)
            {

                return randomMerc;

            }
            else
            {
                GetMerc();

            }


           
            */
            #endregion
          
           
        }

        public bool Compare(Weapon x, Weapon y)
        {
           var xtype = x.GetType();
            var ytype = y.GetType();
           
            if (xtype == ytype)
            {
                return true;
            }
            else
            {
                return false;
            }


           
        }
    }
}
