using System.ComponentModel.DataAnnotations;
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

            [StringLength(2, MinimumLength = 2, ErrorMessage = "O código deve ter exatamente 2 caracteres")]
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
