using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp_TP2.Pages
{
    public class SaveNoteModel : PageModel
    {
        [BindProperty]
        public InputModel Input { get; set; }

        public string DownloadLink { get; set; }

        public class InputModel
        {
            [Required]
            public string Content { get; set; }
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid) return Page();

            var fileName = $"note-{DateTime.Now:yyyyMMddHHmmss}.txt";
            var filePath = Path.Combine("wwwroot/files", fileName);

            Directory.CreateDirectory("wwwroot/files");
            System.IO.File.WriteAllText(filePath, Input.Content);

            DownloadLink = $"/files/{fileName}";
            return Page();
        }
    }
}
