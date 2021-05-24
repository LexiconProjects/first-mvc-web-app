using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMVCWebApp.Models
{
    public class DemoGameModel
    {

        public int Guess { get; set; }
        public static int numberOfGuesses = 0;

        public static int GetRandomNumber()
        {
            var random = new Random(); 
            return random.Next(1, 100);
        }

        public static string CheckUserGuess(int inputGuess, int sessionNumber)
        {
            if (inputGuess < 1 || inputGuess > 100)
                return "Make sure your number is between 1 and 100.";
            
            if (inputGuess > sessionNumber) {
                numberOfGuesses++;
                return "Your guess is too high! Your guess count is: " + numberOfGuesses + ".";
        }
            if (inputGuess < sessionNumber) {
                numberOfGuesses++;
                return "Your guess is too low! Your guess count is: "+numberOfGuesses+".";

            }
            if (inputGuess == sessionNumber)
            {
                int tempGuessCount = numberOfGuesses;
                numberOfGuesses = 0;
                return "Well done! My number was " + sessionNumber + ". \nFinal number of guesses is: "+tempGuessCount+"!";
            }

            return "Please enter your guess.";
        }
    }
}
