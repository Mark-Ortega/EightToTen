
namespace EightToTen.Services.GuessIt;
    public interface IGuessItServices
    {
        string EasyGuess(string guess);
        string MediumGuess(string guess);
        string HardGuess(string guess);
    }
