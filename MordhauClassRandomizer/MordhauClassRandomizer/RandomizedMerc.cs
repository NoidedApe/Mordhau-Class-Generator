using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;
namespace MordhauClassRandomizer
{
    internal class RandomizedMerc
    {  
        int equipPoints = 48;
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
             new armor("nothing", 0, "nothing")
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
           
             new Weapon(1, "lute"),
              new Weapon(1, "shortsword"),
               new Weapon(1, "trainingsword"),
                new Weapon(1, "woodenmallet"),


                 new Weapon(2, "dagger"),
                
                 new TwoHanded(2, "quarterstaff"),
                  
                   



                     new Weapon(3, "cleaver"),


                    
                     new Weapon(4, "blacksmithhammer"),
                  
                    
                     new Weapon(4, "warhammer"),


                     new Weapon(5, "axe"),
                     


                     new Weapon(6, "armingSword"),
                    
                   
                    
                     new Weapon(6, "shawm"),


                     new Weapon(8, "falchion"),


                     
                     new Weapon(9, "heavyHandAxe"),
                     new Weapon(9, "javelin"),
                    
                     new Weapon(9, "shortSpear"),


                     new Weapon(11, "mace"),


                     new Weapon(12, "bastardSword"),
                     new Weapon(12, "rapier"),
                   


                     new TwoHanded(14, "billhook"),
                     new TwoHanded(14, "longsword"),


                     new TwoHanded(15, "battleaxe"),
                     new Weapon(15, "messer"),
                     new Weapon(15, "scimitar"),
                      new TwoHanded(15, "waraxe"),


                     new Weapon(18, "estoc"),
                     new TwoHanded(18, "falx"),
                     new TwoHanded(18, "poleaxe"),
                     new TwoHanded(18, "recurveBow"),


                     new TwoHanded(21, "crossbow"),
                     new TwoHanded(21, "eveningstar"),
                     new TwoHanded(21, "executionerssword"),
                     new TwoHanded(21, "greatsword"),
                     new TwoHanded(21, "maul"),
                     new Weapon(21, "partisan"),


                     new TwoHanded(24, "bardiche"),
                     new TwoHanded(24, "halberd"),
                     new TwoHanded(24, "polehammer"),
                     new Weapon(24, "spear"),
                     
                     new TwoHanded(24, "zweihander"),


                    new TwoHanded(33, "longbow"),









        };
        List<Shields> shields = new List<Shields>()
        {
             new Shields(2, "paviseshield"),
            new Shields(5, "targe"),
              new Shields(6, "heaterShield"),
               new Shields(9, "kiteShield"),
                new Shields(12, "roundShield"),
                new Shields(9, "buckler"),
                 new Shields(0, "nothing")






        };
        List<ConsumablesAndThrowables> ConsumablesAndThrowables = new List<ConsumablesAndThrowables>()
        {     new ConsumablesAndThrowables(2, "smokeBomb"),
             new ConsumablesAndThrowables(1, "bandage"),
            new ConsumablesAndThrowables(24, "toolBox"),
             new ConsumablesAndThrowables(6, "fireBomb"),
              new ConsumablesAndThrowables(6, "medicBag"),
               new ConsumablesAndThrowables(4, "beartrap"),
                new ConsumablesAndThrowables(2, "rock"),
                 new ConsumablesAndThrowables(4, "throwingknife"),
                    new ConsumablesAndThrowables(4, "throwingaxe"),
                    new ConsumablesAndThrowables(0, "nothing")
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




            return null;
           
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
