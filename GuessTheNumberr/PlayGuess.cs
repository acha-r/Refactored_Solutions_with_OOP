using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumberr
{
  internal class PlayGuess
  {

            static int randomNum = new Random().Next(5, 30);
            static int[] collectionOfGuesses = new int[5];
            static int availableTries = 5;
            static int triesUsed = 0;

            private static int InputGuess()
            {
                Console.WriteLine("Guess the number");
                int userInput;
                try
                {
                    userInput = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Enter a valid number");
                    userInput = InputGuess();
                }
                return userInput;
            }
            public static void NumGuess()
            {

                while (true)
                {
                    int userInput = InputGuess();

                    for (int i = 0; i < 5; i++)
                    {
                        if (!(collectionOfGuesses.Contains(userInput)))
                        {
                            collectionOfGuesses[i] = userInput;
                            triesUsed++;
                        }
                    }

                    if (userInput == randomNum)
                    {
                        Console.WriteLine("Your guess was correct!");
                        break;
                    }

                    if (userInput > randomNum)
                    {
                        Console.WriteLine("Your guess was too high");
                    }

                    if (userInput < randomNum)
                    {
                        Console.WriteLine("Your guess was too low");
                    }

                    if (triesUsed == availableTries)
                    {
                        Console.WriteLine($"The number was: {randomNum}");
                        break;
                    }

                    Console.Write($"You have {availableTries - triesUsed} tries left. Enter another number: ");
                }


            }
  }
}
