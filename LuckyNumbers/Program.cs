using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            string exitResp;
            Console.WriteLine("Do you want to play the lottery?");
            exitResp = Console.ReadLine().ToLower();
            while (exitResp == "yes")
            {


                int[] userNums = new int[6];
                int userLowNum;
                int userHighNum;
                decimal jackpotAmount = 1000000000m;
                int correctGuesses = 0;

                //string jackPot
                Console.WriteLine("The JackPot is $" + jackpotAmount);
                Console.WriteLine("Please use numbers 1-80");

                //Ask user for a starting number
                Console.WriteLine("Please pick a starting number");
                userLowNum = int.Parse(Console.ReadLine());

                while (userLowNum < 1 || userLowNum > 80)
                {
                    Console.WriteLine("Invalid input, please pick a number between 1-80");
                    Console.WriteLine("Please pick a starting number");
                    userLowNum = int.Parse(Console.ReadLine());
                }

                //Ask user for a ending number
                Console.WriteLine("Please pick a ending number");
                userHighNum = int.Parse(Console.ReadLine());

                while (userHighNum > 80 || userHighNum <= userLowNum + 6)
                {
                    Console.WriteLine("Invalid input, please pick a number between 1-80");
                    Console.WriteLine("Please pick a ending number");
                    userHighNum = int.Parse(Console.ReadLine());
                }


                //Ask user to input 6 numbers they think will match the lucky numbers generated within the range
                for (int i = 0; i < userNums.Length; i++)
                {
                    Console.WriteLine("Please pick 6 numbers you think will match the Lucky Numbers generated in between your staring and ending numbers");
                    userNums[i] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Your lottery numbers are: ");
                for (int i = 0; i < userNums.Length; i++)
                {
                    Console.Write(userNums[i] + " ");
                }

                Console.WriteLine();
                ////// create random number generator
                //////get six random numbers

                Console.WriteLine("Here are your 6 Lucky Numbers");
                int[] randNum = new int[6];
                // int array for 6 random #s
                //r.Next(min,max)

                Random r = new Random();

                for (int i = 0; i < randNum.Length; i++)

                {

                    randNum[i] = r.Next(1, 12);

                    Console.WriteLine("Lucky Number: " + randNum[i]);

                }

                for (int i = 0; i < userNums.Length; i++)
                {
                    if (randNum.Contains(userNums[i]))
                    {
                        correctGuesses++;
                    }
                }

                Console.WriteLine();
                Console.WriteLine("Correct guesses: " + correctGuesses);
                Console.ReadLine();

                //Logic Requirments
                //Console.WriteLine("You guessed all 6 numbers correctly!");
                //Console.WriteLine("You won $1,000,000 dollars");
                //


                //User Interface part 2
                if (correctGuesses == 6)
                {
                    Console.WriteLine("You've won the Jackpot!!");
                    Console.WriteLine("You've won $" + jackpotAmount + "!!!!!!");
                }
                else
                {
                    Console.WriteLine("You guessed " + correctGuesses + " correctly.");
                    Console.WriteLine("You've won $0.");
                }

                Console.WriteLine("Would you like to play again?");
                exitResp = Console.ReadLine().ToLower();

            }

            Console.WriteLine("Thanks for playing");

        }
    }
}
