using System;

namespace MyThrirdProject
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello, this is the stsrt of the program, please enter if you have an umbrella: \n");
            string input = Console.ReadLine();
            input = input.ToLower();

            if (input == "false")
            {
                Console.WriteLine("Oh no I cannot go outside I don't have an umbrella");                
                
            }
            else
            {
                Console.WriteLine("Good thing I have an Umbrella so I can go outside while it's raining!");
                
            }

            

        }
    }

}
