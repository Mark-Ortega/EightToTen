
namespace EightToTen.Services.GuessIt;
public class GuessItServices : IGuessItServices
{
   public string EasyGuess(string guess)
    {
        Random easyRandom = new Random();
            int easyGuess = easyRandom.Next(1, 11);
            bool isTrue = int.TryParse(guess, out int userGuess1);

            if(isTrue && userGuess1 <= 10)
            {
                if(userGuess1 == easyGuess)
                {
                    return $"You Win, The number guessed was {userGuess1}.";
                }
                else if(userGuess1 > easyGuess)
                {
                    return $"You Lose, Your guess {userGuess1} was more than {easyGuess}.";
                }
                else
                {
                    return $"You Lose, Your guess {userGuess1} was less than {easyGuess}.";

                }
            }
            else
            {
                return "Please enter an integer from 1-10.";
            }
    }

    public string MediumGuess(string guess)
    {
        Random mediumRandom = new Random();
            int mediumGuess = mediumRandom.Next(1, 51);
            bool isTrue = int.TryParse(guess, out int userGuess2);

            if(isTrue && userGuess2 <= 50)
            {
                if(userGuess2 == mediumGuess)
                {
                    return $"You Win, The number guessed was {mediumGuess}.";
                }
                else if(userGuess2 > mediumGuess)
                {
                    return $"You Lose, Your number {userGuess2} was more than {mediumGuess}.";
                }
                else
                {
                    return $"You Lose, Your number {userGuess2} was less than {mediumGuess}.";
                }
            }
            else
            {
                return "Please enter an integer from 1-50.";
            }
    }

    public string HardGuess(string guess)
    {
        Random hardRandom = new Random();
            int hardGuess = hardRandom.Next(1, 101);
            bool isTrue = int.TryParse(guess, out int userGuess3);

            if(isTrue && userGuess3 <= 100)
            {
                if(userGuess3 == hardGuess)
                {
                    return $"You Win, The number guessed was {hardGuess}.";
                }
                else if(userGuess3 > hardGuess)
                {
                    return $"You Lose, Your number {userGuess3} was more than {hardGuess}.";
                }
                else
                {
                    return $"You Lose, Your number {userGuess3} was less than {hardGuess}.";
                }
            }
            else
            {
                return "Please enter in an integer from 1-100.";
            }
    }
}
