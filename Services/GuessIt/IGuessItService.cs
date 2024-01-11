namespace MiniChallengeEightToTenEndpoints.Services.GuessIt;

    public interface IGuessItService
    {
        string GuessItEasy(string userInput);
        string GuessItMedium(string userInput);
        string GuessItHard(string userInput);
    }
