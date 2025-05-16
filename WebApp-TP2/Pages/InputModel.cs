using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp_TP2.Pages
{
    public class InputModel : PageModel
    {
        [BindProperty]
        [Required(ErrorMessage = "Nome obrigatorio")]
        [MinLength(3, ErrorMessage = "Mínimo 3 caracteres")]
        public string CityName { get; set; }
   
    }
}
