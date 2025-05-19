using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp_TP2.Pages.CityManager
{
    public class CityDetailsModel : PageModel
    {
        public string CityName { get; set; }

        public void OnGet(string cityName)
        {
            CityName = cityName ?? "Nenhuma cidade especificada";
        }
    }
}