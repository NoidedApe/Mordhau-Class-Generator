using System;
using System.Collections.Generic;
namespace MordhauClassRandomizer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to generate");
            while (true)
            {
             
                Console.ReadKey();
                DisplayRandomMerc();

            }
           


            
        }
       static void DisplayRandomMerc()
        {
            RandomizedMerc rando = new RandomizedMerc();
            Merc randomizedMerc = rando.GetMerc();
            if (randomizedMerc == null)
            {
                DisplayRandomMerc();

            }else
            {

                if (randomizedMerc.Perk1 != null && randomizedMerc.Perk2 != null && randomizedMerc.Perk3 != null)
                {
                    Console.WriteLine(@$"
Helmet:{randomizedMerc.head.name}
Chest:{randomizedMerc.chest.name}
Legs:{randomizedMerc.legs.name}
Weapons:{randomizedMerc.Weapon.name}
Perks:{randomizedMerc.Perk1.name}, {randomizedMerc.Perk2.name}, {randomizedMerc.Perk3.name}
Consumables and/or throwables:{randomizedMerc.Consumable.name}
Shields:{randomizedMerc.Shield.name}
");
                }
                else if (randomizedMerc.Perk1 != null && randomizedMerc.Perk2 != null)
                {

                    Console.WriteLine(@$"
Helmet:{randomizedMerc.head.name}
Chest:{randomizedMerc.chest.name}
Legs:{randomizedMerc.legs.name}
Weapons:{randomizedMerc.Weapon.name}
Perks:{randomizedMerc.Perk1.name}, {randomizedMerc.Perk2.name}
Consumables and/or throwables:{randomizedMerc.Consumable.name}
Shields:{randomizedMerc.Shield.name}
");

                }
                else if (randomizedMerc.Perk1 != null)
                {
                    
                    Console.WriteLine(@$"
Helmet:{randomizedMerc.head.name}
Chest:{randomizedMerc.chest.name}
Legs:{randomizedMerc.legs.name}
Weapons:{randomizedMerc.Weapon.name}
Perks:{randomizedMerc.Perk1.name}
Consumables and/or throwables:{randomizedMerc.Consumable.name}
Shields:{randomizedMerc.Shield.name}
");
                }
                else
                {
                    Console.WriteLine(@$"
Helmet:{randomizedMerc.head.name}
Chest:{randomizedMerc.chest.name}
Legs:{randomizedMerc.legs.name}
Weapons:{randomizedMerc.Weapon.name}
Perks:None
Consumables and/or throwables:{randomizedMerc.Consumable.name}
Shields:{randomizedMerc.Shield.name}
");


                }


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
}
