
namespace EightToTen.Services.Magic8Ball;
public class Magic8BallServices : IMagic8BallServices
{
    public string M8Ball(string question)
    {
        Random random = new Random();
        int ballInput = random.Next(0, 8);
    

    if(question.Length > 0)
    {
        switch(ballInput)
        {
             case 0:
                    return "It is certain";
                case 1:
                    return "It is decidedly so";
                case 2:
                    return "Without a doubt";
                case 3:
                    return "Reply hazy, Try again";
                case 4:
                    return "Ask again later";
                case 5:
                    return "My Reply is No";
                case 6:
                    return "Outlook not so good";
                case 7:
                    return "Cannot Predict Now";
                case 8:
                    return " Very Doubtful";
                default:
                    return "How?";
        }
    }
    else
    {
        return "Enter a Question";
    }
    }
}
