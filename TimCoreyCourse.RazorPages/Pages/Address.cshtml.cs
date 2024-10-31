using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TimCoreyCourse.RazorPages.Pages
{
    public class AddressModel : PageModel
    {
        [BindProperty]
        public int? HouseNumber { get; set; }

        [BindProperty]
        public string PostCode { get; set; }

        public void OnGet()
        {
        }
        
        public IActionResult OnPost()
        {
            return Page();
        }
    }
}
