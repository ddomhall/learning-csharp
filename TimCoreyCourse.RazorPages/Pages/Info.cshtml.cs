using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TimCoreyCourse.RazorPages.Pages
{
    public class InfoModel : PageModel
    {
        [BindProperty]
        public string Name { get; set; }

        [BindProperty]
        public int? Age { get; set; }

        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            return Page();
        }
    }
}
