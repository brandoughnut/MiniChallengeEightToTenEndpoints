namespace MiniChallengeEightToTenEndpoints.Services.GuessIt;

public class GuessItService : IGuessItService
{
    public string GuessItEasy(string userInput)
    {
        Random rnd = new Random();
            int rndNumber = rnd.Next(1, 11);
            bool isTrue = int.TryParse(userInput, out int number);
            if(isTrue){
                if(number < rndNumber){
                    return $"Your number was too low. The number was {rndNumber}.";
                }else if(number > rndNumber){
                    return $"Your number was too high. The number was {rndNumber}.";
                }else{
                    return "Your number was correct! You win!";
                }
            }else{
                return "That was not a valid input. Try again!";
            }
    }

    public string GuessItMedium(string userInput)
    {
        Random rnd = new Random();
            int rndNumber = rnd.Next(1, 51);
            bool isTrue = int.TryParse(userInput, out int number);
            if(isTrue){
                if(number < rndNumber){
                    return $"Your number was too low. The number was {rndNumber}.";
                }else if(number > rndNumber){
                    return $"Your number was too high. The number was {rndNumber}.";
                }else{
                    return $"Your number was correct! You win!";
                }
            }else{
                return "That was not a valid input. Try again!";
            }
    }

    public string GuessItHard(string userInput)
    {
        Random rnd = new Random();
            int rndNumber = rnd.Next(1, 101);
            bool isTrue = int.TryParse(userInput, out int number);
            if(isTrue){
                if(number < rndNumber){
                    return $"Your number was too low. The number was {rndNumber}.";
                }else if(number > rndNumber){
                    return $"Your number was too high. The number was {rndNumber}.";
                }else{
                    return $"Your number was correct! You win!";
                }
            }else{
                return "That was not a valid input. Try again!";
            }
    }

}
