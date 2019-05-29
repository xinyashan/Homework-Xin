using System;

namespace HW2_XIN
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] pokemart =
{
               "Pokeballs",
               "Super potions",
               "Berries",
               "Escape rope",
               "Great ball",
               "Ultra ball"
             };
            int index = 0;
            foreach (string item in pokemart)
            {
                Console.WriteLine(item);
                Console.WriteLine(index);
                Console.WriteLine(pokemart[index]);
                index++;
            }


            Pokemart();
            dialogue("Welcome to the pokemart! Today we have a sale going on!");
            dialogue("If you buy 10 pokeballs then you 1 free special pokeball as a bonus!");

            int result = equation(99, 100);
            Console.WriteLine(result);
        }






        private static void Pokemart()
        {
            Console.WriteLine("BONUS: Buy 10 and get 1 pokeball for free!");


        }
        private static void dialogue(string words)
        {

        }


        private static int equation(int num1, int num2)
        {
            int returnVariable = num1 + num2;
            return returnVariable;
        }

    }
}




        }
    }
}
