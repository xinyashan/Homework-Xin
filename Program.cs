using System;

namespace CS_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Introduction");
            String rock;
            rock = "Xinya";
            Console.WriteLine(rock);

            int num1 = 9;
            const double num2 = 4.5;
            const float num3 = 4.5f;

            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);

            Console.WriteLine("Hello, {0}, and hello {1}", num1, num3);

            Console.WriteLine(num1 > num2);
            Console.WriteLine(rock == "rock");


            bool lightswitch = false;
            Console.WriteLine(lightswitch);
            Console.WriteLine(lightswitch);

            num1 += 20;
            Console.WriteLine(num1);
            num1 *= 2;
            Console.WriteLine(num1);
            num1 /= 3;
            Console.WriteLine(num1); 

                Console.WriteLine(num1.GetType());

            int num4 = 21;
            int num5 = 42;

            if (num4 < num5); 
            {
                Console.WriteLine("How's it going?");
               
            }

            Console.WriteLine("Do you want to play?");
            string answer = Console.ReadLine();
            answer.ToLower(); 

            if (answer == "yes")
            {
                Console.WriteLine("Ok Lets go");

            } else if (answer == "no")

            {
                Console.WriteLine("Omg"); 

            } else
            {
                Console.WriteLine("You died"); 
            }







       







               



        }
    }
}
