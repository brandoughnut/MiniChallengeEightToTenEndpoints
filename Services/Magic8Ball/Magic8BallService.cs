namespace MiniChallengeEightToTenEndpoints.Services.Magic8Ball;

public class Magic8BallService : IMagic8BallService
{
    public string Magic8Ball()
    {
        Random rnd = new Random();
            int rndNumber = rnd.Next(1, 9);

            if(rndNumber == 1){
                return "You are going to have a horrible day today!";
            }else if(rndNumber == 2){
                return "You will be blessed with an act of kindness today.";
            }else if(rndNumber == 3){
                return "You deserve a break, go take a rest.";
            }else if(rndNumber == 4){
                return "You should take a family member out to lunch.";
            }else if(rndNumber == 5){
                return "I think you should go outside and get some fresh air.";
            }else if(rndNumber == 6){
                return "I hope you will be missing a sock.";
            }else if(rndNumber == 7){
                return "Everything happens for a reason.";
            }else {
                return "I don't know, go ask someone else."; 
            }
    }
}
