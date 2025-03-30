using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyWebSite.Pages
{
    public class IndexModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Bienvenue sur mon site personnel !";
        }
    }
}
