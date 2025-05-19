using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp_TP2.Pages.CityManager
{
    public class CreateCityModel : PageModel
    {
        public class InputModel
        {
            [Required(ErrorMessage = "O nome da cidade é obrigatório")]
            [MinLength(3, ErrorMessage = "Mínimo 3 caracteres")]
            public string CityName { get; set; }
        }

        [BindProperty]
        public InputModel Input { get; set; } = new InputModel();
        
        [TempData]
        public string SubmittedCityName { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            SubmittedCityName = Input.CityName;
            return Page();
        }

        public IActionResult OnPostViewDetails()
        {
            if (string.IsNullOrEmpty(SubmittedCityName))
            {
                TempData["ErrorMessage"] = "Nenhuma cidade cadastrada para visualizar";
                return RedirectToPage();
            }
            return RedirectToPage("./CityDetails", new { cityName = SubmittedCityName });
        }
    }
}
