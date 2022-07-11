using System;
using System.Collections.Generic;
using System.IO;

namespace MordhauClassRandomizer
{
    public class Program
    {
       
        #region strings
        public static string path = ".\\directory.txt";
        public static string dir;
        public static string perk1string = "";
        public static string perk2string = "";
        public static string perk3string = "";
        public static string cheststring = "None";
        public static string headstring = "None";
        public static string legsstring = "None";
        public static string shieldstring = "None";
        public static  string consumablestring = "None";
        public static string throwable = "None";
        public static string replacetext = "SingletonVersion=11";
       
        #endregion
       public static bool perk1, perk2, perk3, chest, head, legs, consumable, shield, throwable1,perk1empty,perk2empty,perk3empty;
        public static void Main(string[] args)

        {

           

            if (File.Exists(path))
            {
                dir = File.ReadAllText(path);
                Console.WriteLine(@dir);
                 Console.WriteLine("Press any key to generate. Input A or a then hit Enter to save.");
                 while (true)
                 {
             
                
                 DisplayRandomMerc();

                 }
            }else
            {
                CreateDirFile();

            }
           
           


            
        }
       static void DisplayRandomMerc()
        {
            RandomizedMerc rando = new RandomizedMerc();
            Merc ran = rando.GetMerc();
           
            
            if (ran.equipPointsRemaining < 3)
                rando.GetMerc();
            if (ran.Perk1 != null && ran.Perk1.name != "")
                perk1string = ran.Perk1.name;
            if (ran.Perk2 != null && ran.Perk2.name != "")
                perk1string = perk1string + "," + ran.Perk2.name;
            if (ran.Perk3 != null && ran.Perk3.name != "")
                perk1string = perk1string + "," + ran.Perk3.name;
            if (ran.chest != null)
                cheststring = ran.chest.name;
            if (ran.legs != null)
                legsstring = ran.legs.name;
            if (ran.head != null)
                headstring = ran.head.name;
            if (ran.Consumable.ID != null)
                consumablestring = ran.Consumable.name;
            if (ran.Shield != null)
                shieldstring = ran.Shield.name;
            if (ran.throwable.ID != null)
                consumablestring = ran.throwable.name + "," + consumablestring;

            if (ran.equipPointsRemaining < 0)
                DisplayRandomMerc();
            
            if (ran.equipPointsRemaining >= 0)
            {
                Console.WriteLine(@$"
    Weapon:{ran.Weapon.name}
    Shield:{shieldstring}
    Helmet:{headstring}
    Chest:{cheststring}
    Legs:{legsstring}
    Consumable/throwables:{consumablestring}
    Perks:{perk1string}
    Points remaining:{ran.equipPointsRemaining}
");


            }
         






            string key = Console.ReadLine();
            if (key == "a" || key == "A")
            {
                int? idHead, idChest, idLegs, idPerk1, idPerk2, idPerk3, idConsumable, idThrowable, idShield, allPerksNumber, idWeapon;
                if (ran.head != null)
                idHead = ran.head.ID;
                else
                    idHead = null;

                if (ran.legs != null)      
                    idLegs = ran.legs.ID;
                else
                idLegs = null;
                if (ran.chest != null)
                    idChest = ran.chest.ID;
                else
                    idChest = null;

                if (ran.Perk1 != null && ran.Perk1.name != "")
                    idPerk1 = ran.Perk1.ID;
                else
                    idPerk1 = null;
                if (ran.Perk2 != null && ran.Perk2.name != "")
                    idPerk2 = ran.Perk2.ID;
                else
                    idPerk2 = null;
                if (ran.Perk3 != null && ran.Perk3.name != "")
                    idPerk3 = ran.Perk3.ID;
                else
                    idPerk3 = null;
                if (ran.Consumable != null)
                    idConsumable = ran.Consumable.ID;
                else
                    idConsumable = null;
                if (ran.throwable != null)
                    idThrowable = ran.throwable.ID;
                else
                    idThrowable = null;
                if (ran.Shield != null)
                    idShield = ran.Shield.ID;
                else
                    idShield = null;
                if (ran.Weapon != null)
                    idWeapon = ran.Weapon.ID;
                else
                    idWeapon = null;

                allPerksNumber = idPerk1 + idPerk2 + idPerk3;
                WriteMerc(idHead, idChest, idLegs, idWeapon, idShield, allPerksNumber, idConsumable, idThrowable);

            }
               
            


        }
       public  static void WriteMerc(int? idHead, int? idChest, int? idLegs, int? idWeapon, int? idShield, int? idPerks, int? idConsumable, int? idThrowable)
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
                new Perk(0, "none", 0)
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
               new ConsumablesAndThrowables(9, "javelin",64),
                new ConsumablesAndThrowables(0, "nothing",0)
        };
            #endregion







           
            Console.WriteLine("Enter a name.");
            string namemerc = Console.ReadLine();

            if (idPerks == null)
                idPerks = 0;

            
            string alltext = File.ReadAllText(@dir);
            string template = new string($"CharacterProfiles = (Name = INVTEXT(\"{namemerc}\"), GearCustomization = (Wearables = ((ID = {idHead}, Colors = (22, 22), Pattern = 4), (ID = {idChest}, Colors = (22, 0)), (ID = {idLegs}, Colors = (22, 0)), (ID = 13, Colors = (22, 22)), (ID = 45, Colors = (22, 0)), (ID = 31, Colors = (22, 0)), (ID = 16, Colors = (23, 19)), (ID = 23, Colors = (22, 0), Pattern = 2), ()), Equipment = ((ID = {idWeapon}, Skin = 1), (ID = {idConsumable}), (ID = {idThrowable}))), AppearanceCustomization = (Emblem = 61, EmblemColors = (22, 9), MetalRoughnessScale = 255, MetalTint = 2, Age = 0, Voice = 8, VoicePitch = 150, bIsFemale = False, Fat = 85, Skinny = 85, Strong = 85, SkinColor = 0, Face = 0, EyeColor = 0, HairColor = 0, Hair = 0, FacialHair = 0, Eyebrows = 0), FaceCustomization = (Translate = (65535, 65535, 65535, 65535, 65535, 65535, 65535, 0, 65535, 65535, 65535, 65535, 65535, 0, 0, 0, 0, 0, 65535, 65535, 65535, 0, 65535, 0, 65535, 65535, 65535, 65535, 65535, 0, 65535, 0, 65535, 65535, 0, 65535, 0, 65535, 0, 65535, 0, 0, 65535, 65535, 65535, 65535, 65535, 65535, 0), Rotate = (0, 65535, 0, 65535, 0, 0, 0, 0, 0, 65535, 65535, 65535, 0, 65535, 0, 0, 0, 0, 0, 65535, 0, 0, 65535, 0, 0, 0, 65535, 65535, 65535, 0, 0, 0, 0, 65535, 65535, 0, 65535, 0, 0, 0, 65535, 0, 65535, 65535, 65535, 65535, 65535, 65535, 65535), Scale = (65535, 65535, 65535, 0, 0, 0, 0, 0, 65535, 65535, 65535, 65535, 0, 0, 0, 65535, 65535, 65535, 65535, 0, 0, 65535, 0, 0, 0, 0, 0, 65535, 65535, 0, 0, 0, 0, 65535, 0, 65535, 0, 0, 65535, 0, 65535, 65535, 0, 0, 65535, 65535, 65535, 0, 0)), SkillsCustomization = (Perks = {idPerks}), Category = \"\"");

                //($"CharacterProfiles=(Name=INVTEXT(\"{namemerc}\"),GearCustomization=(Wearables=(({idHead}),(),({idChest}),(),(),(),(),({idLegs}),()),Equipment=(({idWeapon}),({idConsumable}),({idThrowable}))),AppearanceCustomization=(Emblem=0,EmblemColors=(0,0),MetalRoughnessScale=0,MetalTint=0,Age=0,Voice=8,VoicePitch=0,bIsFemale=False,Fat=85,Skinny=85,Strong=85,SkinColor=0,Face=0,EyeColor=0,HairColor=0,Hair=0,FacialHair=0,Eyebrows=0),FaceCustomization=(Translate=(0,65535,65535,65535,0,65535,0,0,65535,65535,65535,65535,65535,65535,0,65535,65535,65535,0,0,0,0,0,65535,65535,0,65535,0,65535,65535,0,0,0,65535,0,65535,65535,65535,0,65535,65535,0,65535,65535,65535,65535,65535,65535,0),Rotate=(0,0,65535,65535,65535,65535,65535,65535,0,0,65535,0,0,65535,65535,0,65535,65535,65535,65535,0,65535,0,65535,0,0,65535,0,0,65535,0,0,0,65535,65535,0,65535,65535,0,0,65535,65535,65535,0,0,0,0,65535,0),Scale=(65535,65535,65535,65535,0,65535,65535,0,0,0,0,0,0,65535,65535,65535,65535,65535,65535,0,0,65535,0,65535,0,65535,65535,65535,0,0,0,0,0,0,65535,0,65535,65535,0,65535,0,65535,65535,65535,0,65535,65535,0,65535)),SkillsCustomization=(Perks={idPerks}),Category=\"\")");

            template = "SingletonVersion=11" + "\n" + template;
             alltext = alltext.Replace("SingletonVersion=11", template);
          
            var myini = new IniFile(dir);
            string alltext1 = myini.Read("[/ Script / Mordhau.MordhauGameMode]");
          
            bool yesno = myini.KeyExists("[/ Script / Mordhau.MordhauGameMode]");
            if (yesno == true)
                myini.Write("[/ Script / Mordhau.MordhauGameMode]", alltext);

          
           
            File.WriteAllText(@dir, alltext);
            Console.WriteLine("\t-----------------------------------");
            Console.WriteLine("\tCharacter written to Game.ini");
            Console.WriteLine("\t-----------------------------------");
            Console.WriteLine("\tPress enter to continue generating.");
            Console.WriteLine("\t-----------------------------------");
            Console.ReadKey();
        }
        static void CreateDirFile()
        {
            Console.WriteLine(@"Type the directory of your mordhau saves. It should be in appdata\local\mordhau\saved\config\windowsclient\game.ini
Make sure to include the Game.ini file in the directory.
Press A and then enter if you want to save. anything else will skip to the next generation.");
            string dir = Console.ReadLine();

           
            File.WriteAllText(path, @dir);
            Console.WriteLine("Directory text file created. Please do not remove or delete it or you will have to enter it on startup every time.");
            Main(null);

        }
        








            /*
            Console.WriteLine(@$"
Helmet:{randomizedMerc.head.name}
Chest:{randomizedMerc.chest.name}
Legs:{randomizedMerc.legs.name}
Weapons:{randomizedMerc.Weapon.name}
Perks:{randomizedMerc.Perk1.name}, {randomizedMerc.Perk2.name}, {randomizedMerc.Perk3.name}
");*/


        }
    }

