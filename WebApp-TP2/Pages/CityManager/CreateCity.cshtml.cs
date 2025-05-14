using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp_TP2.Pages.CityManager
{
    public class CreateCityModel : PageModel
    {
        public string CityName { get; set; }

        public void OnPost(string cityName) 
        {
            if (string.IsNullOrEmpty(cityName))
            {
                ModelState.AddModelError("name", "City name is required.");
                return;
            }

            CityName = cityName;
        }
    }
}
