using System;

namespace DiceRollApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Dice Roller");
            string cont = "C";
            int dieSides = 0;

            while(!cont.Equals("N") && !cont.Equals("n"))
            {
                if(cont.Equals("C") || cont.Equals("c"))
                {
                    Console.Write("How many sides should each die have? ");
                    dieSides = Convert.ToInt32(Console.ReadLine());
                    if (dieSides <= 0)
                        continue;
                }
                int die1 = generateRandomDieRoll(dieSides);
                int die2 = generateRandomDieRoll(dieSides);

                Console.WriteLine("You rolled " + die1 + " and " + die2 + "!");
                Console.WriteLine("Roll again?(y/n) Or enter \"C\" to change dice sides: ");
                cont = Console.ReadLine();
            }
            Console.Write("Goodbye!");
        }
        public static int generateRandomDieRoll(int dieSides)
        {
            Random rand = new Random();
            return rand.Next(1, dieSides+1);
        }
    }
}
