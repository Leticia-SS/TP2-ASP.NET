using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp_TP2.Pages.CityManager
{
    public class CreateCityModel : PageModel
    {
        [BindProperty]
        public string cityName { get; set; }

        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                return;
            }
        }
    }
}
