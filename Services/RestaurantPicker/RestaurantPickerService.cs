namespace MiniChallengeEightToTenEndpoints.Services.RestaurantPicker;

public class RestaurantPickerService : IRestaurantPickerService
{
    public string RestaurantPicker(string fastFoodchickenfineDining)
    {
        Random rnd = new Random();
        string[] fastFood = {"McDonalds", "Taco Bell", "Subway", "Wendys", "Jack in the Box", "Five Guys", "In n Out", "Carls Jr.", "Domino's", "Chipotle"};
        string[] chicken = {"Popeyes", "KFC", "Chick Fil A", "Bonchon", "Wing Stop", "Angry Chickz", "Jollibee", "Church's", "Fire Wings", "Raising Canes"};
        string[] fineDining = {"Boulevard Bistro", "Firehouse Restaurant", "Localis", "Moxie Restaurant", "Ruth's Chris Steak House", "Brasserie du Monde", "The Kitchen Restaurant", "Ella Dining Room & Bar", "Mulvaney's B&L", "The Melting Pot"};
        int rndNumber = rnd.Next(0, fastFood.Length);

        if(fastFoodchickenfineDining.ToLower() == "fast food" || fastFoodchickenfineDining.ToLower() == "fastfood"){
            return $"The restaurant you should go to is {fastFood[rndNumber]}.";
        }else if(fastFoodchickenfineDining.ToLower() == "chicken"){
            return $"The restaurant you should go to is {chicken[rndNumber]}.";
        }else if(fastFoodchickenfineDining.ToLower() == "fine dining" || fastFoodchickenfineDining.ToLower() == "finedining"){
            return $"The restaurant you should go to is {fineDining[rndNumber]}.";
        }else{
            return "Your input does not match our category. Try Again";
        }
    }
}
