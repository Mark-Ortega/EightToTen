
using EightToTen.Services.ResturantPicker;
using Microsoft.AspNetCore.Mvc;

namespace EightToTen.Controllers;
    public class ResturantPickerController : ControllerBase
    {
        private readonly IResturantPickerServices _resturantPickerServices;

        public ResturantPickerController(IResturantPickerServices resturantPickerServices)
        {
            _resturantPickerServices = resturantPickerServices;
        }

        [HttpGet]
        [Route("ResturantPicker/{mexicanChineseFastfood}")]

        public string PickResturant(string mexicanChineseFastfood)
        {
            return _resturantPickerServices.PickResturant(mexicanChineseFastfood);
        }
    }
