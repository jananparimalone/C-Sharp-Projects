using System;
using System.Net.Security;

namespace BuildingAGuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "giraffe";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            //The next statement says the while loop is going to check if the the guess string is != (notequal) to the secret word
            //If it not equal to the secret word (declared above, it is "Giraffe") it will start over
            //If it is = to the secretWord variable the while loop ends, and the console prints You Win!

            while (guess != secretWord && !outOfGuesses)
            {
                //The if statement is to check the amount of guesses, the guessLimit variable has been set to 3
                //if the guessCount variable, which begins incrementing within the while loop, is < (less than) to the guessLimit
                //then the Console will print "exceeds max guesses"
                //I also added the && !outofGuesses statement to my while loop to break the loop if the player runs out of guesses

                if (guessCount < guessLimit)
                {
                    Console.Write("Enter guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;
                }
            }
            //down here I have to use another if statement to check which response the console will give me depending on the reason it broke out of the while loop
            if (outOfGuesses)
            {
                Console.Write("Exceeds Max Guesses");
            }
            else
            {
                Console.Write("You Win!");

                Console.ReadLine();
            }
        }
    }
}
