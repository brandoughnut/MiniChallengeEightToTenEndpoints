using Microsoft.AspNetCore.Mvc;
using MiniChallengeEightToTenEndpoints.Services.RestaurantPicker;

namespace MiniChallengeEightToTenEndpoints.Controllers;

    [ApiController]
    [Route("[controller]")]
    public class RestaurantPickerController : ControllerBase
    {
    private readonly IRestaurantPickerService _restaurantPickerService;

    public RestaurantPickerController(IRestaurantPickerService restaurantPickerService)
        {
        _restaurantPickerService = restaurantPickerService;
    }
        [HttpGet]
        [Route("Please Choose a Restaurant: fast food, chicken, or fine dining/{fastFoodchickenfineDining}")]
        public string RestaurantPicker(string fastFoodchickenfineDining)
        {
            return _restaurantPickerService.RestaurantPicker(fastFoodchickenfineDining);
        }

    }
