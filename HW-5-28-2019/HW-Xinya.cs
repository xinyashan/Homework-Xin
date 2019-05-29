using System;

namespace Homework_xinya
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Hello! Welcome to the Poke'mart traveler! I see you're running low on items. You need more Pokeballs if you want to " +
                "catch more Pokemon. Please browse through our category ");

            Console.WriteLine("Which items would you like to buy?");

            Console.WriteLine("Pick a choice: 1, Pokeball x99, 2, potions x99, 3, Repels x99");
            string answer1 = Console.ReadLine();

            switch (answer1)
            {
                case "1":
                    Console.WriteLine("Thanks for buying the pokeballs! Please come again!");
                    break;

                case "2":
                    Console.WriteLine("Thanks for buying the potions! Please come again!");
                    break;

                case "3":
                    Console.WriteLine("Thanks for buying the repels! PLease come again!");
                    break;

                default:
                    Console.WriteLine("Sorry we can't get that item for you. Would you like to browse through our catagory again?");
                    break;
            }

            {
                Console.WriteLine("Hi there! It seems we have more items in our shop");
                Console.WriteLine("Which item would you like to buy from our special list?");

                Console.WriteLine("Pick a choice: 1, Max potion x99, 2, Revival herbs x99, 3, Master ball x99");
                string answer2 = Console.ReadLine();
                switch (answer2)
                {
                    case "1":
                        Console.WriteLine("Thanks for buying the max potions! Heal up your party members and continue your quest!");
                        break;

                    case "2":
                        Console.WriteLine("Thanks for buying the revival herbs! Your Pokemons will thank you.");
                        break;

                    case "3":
                        Console.WriteLine("Thanks for buying the master balls! You can now catch any Pokemon you want!");
                        break;

                    default:
                        Console.WriteLine("Unfortunatly that is not available.");
                        break;
                }


            }

            {
                Console.WriteLine("Our secret shop also gives customer a chance to adopt some rare Pokemon.");
                Console.WriteLine("Which Pokemon do you want to obtain? 1, Shiny Charizard, 2, Shiny Blastoise, 3, Shiny Venusaur");

                string answer3 = Console.ReadLine();
                switch (answer3)
                {
                    case "1":
                        Console.WriteLine("You chose CHARIZARD! It is level 50!");
                        Console.WriteLine("[Moves: Fire Punch, fly, flamethrower, and Hyper beam]");
                        Console.WriteLine("Item held: Sitrus berry"); 
                        break;

                    case "2":
                        Console.WriteLine("You choose BLASTOISE! It is level 50!");
                        Console.WriteLine("[Moves: Scald, ice beam, aqua jet, and dragon tail]");
                        Console.WriteLine("Item held: Chocolate"); 
                        break;

                    case "3":
                        Console.WriteLine("You chose VENESAUR! It is level 50!");
                        Console.WriteLine("[Moves: Solar beam, Sunny day, Toxic, and Reflect]");
                        Console.WriteLine("Item held: Cherry pie"); 
                        break;

                    default:
                        Console.WriteLine("Sorry we can't get that Pokemon for you!");
                        break;

                }
            }

        }

}

}
   







