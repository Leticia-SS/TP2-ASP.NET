using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp_TP2.Pages.CityManager
{
    public class CreateCountryModel : PageModel
    {
        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            public string CountryName { get; set; }
            public string CountryCode { get; set; }
        }

        public void OnPost()
        {
            var country = new Country
            {
                CountryName = Input.CountryName,
                CountryCode = Input.CountryCode
            };
        }
    
    }
}
