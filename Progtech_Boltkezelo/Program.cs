using Progtech_Boltkezelo.CharacterCreation;
using System;
using System.Collections.Generic;
using Progtech_Boltkezelo.EquippingAnItem;
using Progtech_Boltkezelo.Map;

namespace Progtech_Boltkezelo
{
    class Program
    {
        static void Main(string[] args)
        {
            CharacterFactory factory = new CharacterFactory();
            List<CharacterCreate> CharacterList = new List<CharacterCreate>();
            do
            {

                Console.WriteLine("Please choose a character and write (a/b)! \n Choosable characters: ");
                Console.WriteLine("a) Magician \nb) Warrior");

                String charactertype = Console.ReadLine();

                while (!(charactertype == "a" || charactertype == "b"))
                {
                    Console.WriteLine("Please try again !");
                    charactertype = Console.ReadLine();
                }

                CharacterCreate character = factory.creatCharacter(charactertype);


                CharacterList.Add(character);

                Console.WriteLine("Want to buy another character? If yes write yes.");
             
            } while (Console.ReadLine() == "yes");

            


            CharacterBase choose = new Characters(CharacterList);
            Console.WriteLine("Please choose one item. ");
            Console.WriteLine("a) 1 \nb) 2 \nc) 3");

            string item = Console.ReadLine();

            while (!(item == "a" || item == "b" || item == "c"))
            {
                Console.WriteLine("Please try again!");
                item = Console.ReadLine();
            }

            switch (item)
            {
                case "a": choose = new ChoosingTheFirstItem(choose);
                    break;
                case "b":
                    choose = new ChoosingTheFirstItem(choose);
                    break;
                case "c":
                    choose = new ChoosingTheFirstItem(choose);
                    break;
            }

            Generator generator = new Generator();
            Console.WriteLine("Please choose a map. ");
            Console.WriteLine("a) small \nb) medium \nc) big");

            string map = Console.ReadLine();

            while (!(map == "a" || map == "b" || map == "c"))
            {
                Console.WriteLine("Please try again!");
                map = Console.ReadLine();
            }

            switch (map)
            {
                case "a":
            
                  generator.Choose(new Small());
                    generator.MapGen();
                    break;
                case "b":
                    generator.Choose(new Medium());
                    generator.MapGen();
                    break;
                case "c":
                    generator.Choose(new Big());
                    generator.MapGen();
                    break;
            }

           


            for (int i = 0; i < CharacterList.Count; i++)
            { 
                Console.WriteLine(CharacterList[i]); 
            }


            Console.WriteLine(choose.getPrice() + " Point is the cost.");
           
        }
    }
}

