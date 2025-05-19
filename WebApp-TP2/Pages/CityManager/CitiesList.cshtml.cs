using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp_TP2.Pages.CityManager
{
    public class CitiesListModel : PageModel
    {
        public List<string> Cities { get; } = new List<string> { "Rio", "São Paulo", "Brasília" };

    }
}
