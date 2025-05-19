using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp_TP2.Pages.CityManager
{
    public class CreateCountryModel : PageModel
    {
        [BindProperty]
        public List<InputModel> Countries { get; set; } = new List<InputModel>();

        public void OnGet()
        {
            for (int i = 0; i < 5; i++)
            {
                Countries.Add(new InputModel());
            }
        }

        public void OnPost()
        {
            var countryList = Countries.Select(c => new Country
            {
                CountryName = c.CountryName,
                CountryCode = c.CountryCode
            }).ToList();
        }

        public class InputModel
        {
            public string CountryName { get; set; }

            [StringLength(2, MinimumLength = 2)]
            public string CountryCode { get; set; }
        }
    }
}
